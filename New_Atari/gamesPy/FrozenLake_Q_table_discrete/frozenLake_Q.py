# -*- coding: utf-8 -*-
"""
Created on Sun Sep  1 23:46:41 2019

@author: user
"""
import numpy as np
import gym
import random
import time
from IPython.display import clear_output
from utilites import plotLearning



class Agent():
    def __init__(self, action_space_size, state_space_size, num_episodes=10000 ,max_steps_per_episode=100,
                 learning_rate=0.01 , discount_rate=0.99, exploration_rate=1, max_exploration_rate=1,
                 min_exploration_rate=0.01, exploration_decay_rate=0.001):
        self.action_space_size=action_space_size
        self.state_space_size=state_space_size
        self.num_episodes=num_episodes
        self.max_steps_per_episode=max_steps_per_episode
        self.learning_rate=learning_rate
        self.discount_rate=discount_rate
        self.exploration_rate=exploration_rate
        self.max_exploration_rate= max_exploration_rate
        self.min_exploration_rate=min_exploration_rate
        self.exploration_decay_rate=exploration_decay_rate 
        #self.env=env
        
        
    def learn(self, q_table):
        env= gym.make("FrozenLake-v0")
        #all the rewards we will get from each episode
        #to see how the game score will change over time
        rewards_all_episodes = []
        ecploration_all_epis = []
        # Q-learning algorithm
        #evrything that happens in a single episode
        for episode in range(self.num_episodes):
            #reset the state of the environment
            state = env.reset()
            
            #the episode is not finished
            done= False
            #keep track of rewards in the current episode
            #no rewards at the begining of each episode
            rewards_current_episode=0
            # initialize new episode params
            #everything that will happen in a time step in each single episode
            for step in range(self.max_steps_per_episode):
                #to determine if the agent will explore or exploit the environment in this time step
                exploration_rate_threshold = random.uniform(0,1)
                if  exploration_rate_threshold > self.exploration_rate:
                    #then exploite and choose the action with the highest q_value
                    action= np.argmax(q_table[state,:])
                else:
                    #the agent will explore the environment
                    action= env.action_space.sample()
                    
                    #step will return a queue that contain the following
                new_state, reward, done, info= env.step(action)
                    
                    #update Q_table for Q(s,a)
                      
                q_table[state, action]= q_table[state, action]* (1-self.learning_rate)+ \
                        self.learning_rate* (reward + self.discount_rate *np.max(q_table[new_state, :]))
                state= new_state
                rewards_current_episode +=reward
                    
                if done == True:
                    break
                    # Exploration-exploitation trade-off
            
            #when the episode is finished we need to upa=date the exploration rate
            self.exploration_rate= self.min_exploration_rate + \
              (self.max_exploration_rate -self.min_exploration_rate)* np.exp(-self.exploration_decay_rate *episode)
        
        #append the reward from episode to the list of rewards 
            rewards_all_episodes.append(rewards_current_episode)
            ecploration_all_epis.append(self.exploration_rate)
        
        rewards_per_thosand_episodes = np.array_split(np.array(rewards_all_episodes),(self.num_episodes/1000))
        count = 1000
        print("********Average reward per thousand episodes********\n")
        for r in rewards_per_thosand_episodes:
            print(count, ": ", str(sum(r/1000)))
            count += 1000
            
        return q_table, rewards_all_episodes, ecploration_all_epis

"""    
class Q_Table():
    def __init__(state_space_size,action_space_size):
        q_table= np.zeros((state_space_size,action_space_size))
        """
            
            

