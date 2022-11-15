# -*- coding: utf-8 -*-
"""
Created on Mon Sep  2 23:02:34 2019

@author: user
"""

import gym
import numpy as np 
from utilities import utilities_Q
from Q_table import Q_table_Con_to_discrete
from Agent import Agent_Q
import time
from IPython.display import clear_output
#finally our main function when we start the programe we first wanna create our bins
#then we wanna get the episode length, and episode reward by playing a bunch of games
#and then we are gonna plot the running average over time
if __name__ == '__main__':
    #training process
    max_state = 10**4
    discount = 0.9
    lr = 0.01
    training_episode=10000
    util= utilities_Q()
    bins = util.create_bins()
    agent= Agent_Q(bins,  max_state = 10**4, discount = 0.9, lr = 0.01, training_episode=10000)
    episode_lengths, episode_rewards, Q = agent.learn()

    #util.plot_running_avg(episode_rewards)
    filename= "cartPole.png"
    util.plot_running_avg( episode_rewards, filename=filename, window= 500)
    #play 
    play_rewards=[]
    action_count=[]
    env= gym.make('CartPole-v0')
    for episode in range(10):
        observation = env.reset()
        done = False
        print("********Episode ",episode+1, "*****\n\n\n\n")
        time.sleep(1)
        cnt = 0 # number of moves in an episode
        #we will first get the current state 
        state = util.state_as_string(util.assign_bins(observation, bins))
        #and we wanna set the total reward for this game to zero, because that's what we wanna keep track of
        total_reward = 0
        clear_output(wait=True)
        #so while we are not done we wanna keep track of how many moves we are taking
        while not done:
            env.render()
            time.sleep(0.03)
            cnt += 1
            #and then we are gonna come down to the epsilon greedy strategy
            #if the random is less than epsilon we will take a random action, and if it's 
            #greater or equal to epsilon, you wanna find the action that gives you the maximum future reward 
            # np.random.randn() seems to yield a random action 50% of the time ?
            act = util.max_value_in_table(Q[state])[0] # epsilon greedy
    
            #and that we know what action to take we will use the step function to to take that action
            observation, reward, done, _ = env.step(act)
            env.render()
            #and we will accumelate the reward because the reward is on for each step so we are just adding one every time step ,except when the pole 
            #falls over, you don't want to trate the pole falling over the same as a successful move, because then it wont really learn
            total_reward += reward
    
            if done:
                env.render()
                print( total_reward, cnt)
                play_rewards.append(total_reward)
                action_count.append(cnt)
                
                
            #then we want to get our new state, because in Q-learning you need to maximize the future reward, and since you already stepped in you wanna take a look at this new state
            state_new = util.state_as_string(util.assign_bins(observation, bins))
            a1, max_q_s1a1 = util.max_value_in_table(Q[state_new])
            #the next step is to uodate your Q-learning array, you wanna update the excpected future award in the previeus state for a given action
            #max_q_s1a1 is the reward assosiated with the new state
            Q[state][act] += lr*(reward + discount*max_q_s1a1 - Q[state][act])
            #and then we wanna keep track of where we currently are
            state, act = state_new, a1
            #and this is gonna itterate until it finishes or flopes over, and when it does we are gonna return 
            #the total reward and the number of steps
            
    env.close()
    print(play_rewards, action_count)
    
