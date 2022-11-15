# -*- coding: utf-8 -*-
"""
Created on Mon Sep  2 22:39:29 2019

@author: user
"""
import gym
import numpy as np 
from utilities import utilities_Q
from Q_table import Q_table_Con_to_discrete

class Agent_Q():
     #those are parameters from the Q-learning mathematics, has to do with hpw we actually update the Q-values in the table and how to discount future rewards
    def __init__(self, bins, max_state = 10**4,discount = 0.9, lr = 0.01, training_episode=10000):
        self.envName='CartPole-v0'
        self.max_state= max_state
        self.discount= discount
        self.lr= lr
        self.bins = bins
        self.training_episode =training_episode
        
    def learn(self):
        table= Q_table_Con_to_discrete()
        Q = table.creatTable()

        #length and reward will just keep track of the total number of steps, and total rewards of a given game
        length = []
        reward = []
        #and we wanna loop over n which is the total number of games we wanna play
        for n in range(self.training_episode):
            #the following equations of epsilon will garenty that epsilon will decrese over time so as we prosses 
            #the probabilty that we will chose random actions will decrese
            #eps=0.5/(1+n*10e-3)
            eps = 1.0 / np.sqrt(n+1)
    
            #then we wanna get the reward for that episode, and its length by playing one game
            episode_reward, episode_length = self.play_one_game(self.bins, Q, eps)
    
            #we added this print statement just to know where we are, as will as the current reward
            #and the current epsilon, and we are also gonna append those to our arrays
            if n % 100 == 0:
                print(n, '%.4f' % eps, episode_reward)
            length.append(episode_length)
            reward.append(episode_reward)
    
        #then we are gonna return the length and reward after playing 10000 games
        return length, reward, Q
    
    #then we want to play ine game
    def play_one_game(self,bins, Q, eps=0.5):
        util= utilities_Q()
        env= gym.make(self.envName)
        # as we have done before first we want to reset the environment
        #then we set the done and cnt flages 
        observation = env.reset()
        done = False
        cnt = 0 # number of moves in an episode
        #we will first get the current state 
        state = util.state_as_string(util.assign_bins(observation, bins))
        #and we wanna set the total reward for this game to zero, because that's what we wanna keep track of
        total_reward = 0
    
        #so while we are not done we wanna keep track of how many moves we are taking
        while not done:
            cnt += 1
            #and then we are gonna come down to the epsilon greedy strategy
            #if the random is less than epsilon we will take a random action, and if it's 
            #greater or equal to epsilon, you wanna find the action that gives you the maximum future reward 
            # np.random.randn() seems to yield a random action 50% of the time ?
            if np.random.uniform() < eps:
                act = env.action_space.sample() # epsilon greedy
            else:
                act = util.max_value_in_table(Q[state])[0]
    
            #and that we know what action to take we will use the step function to to take that action
            observation, reward, done, _ = env.step(act)
    
            #and we will accumelate the reward because the reward is on for each step so we are just adding one every time step ,except when the pole 
            #falls over, you don't want to trate the pole falling over the same as a successful move, because then it wont really learn
            total_reward += reward
    
            if done and cnt < 200:
                reward = -300
            #then we want to get our new state, because in Q-learning you need to maximize the future reward, and since you already stepped in you wanna take a look at this new state
            state_new = util.state_as_string(util.assign_bins(observation, bins))
            a1, max_q_s1a1 = util.max_value_in_table(Q[state_new])
            #the next step is to uodate your Q-learning array, you wanna update the excpected future award in the previeus state for a given action
            #max_q_s1a1 is the reward assosiated with the new state
            Q[state][act] += self.lr*(reward + self.discount*max_q_s1a1 - Q[state][act])
            #and then we wanna keep track of where we currently are
            state, act = state_new, a1
            #and this is gonna itterate until it finishes or flopes over, and when it does we are gonna return 
            #the total reward and the number of steps
        return total_reward, cnt
