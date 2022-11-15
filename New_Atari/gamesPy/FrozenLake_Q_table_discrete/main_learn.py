# -*- coding: utf-8 -*-
"""
Created on Mon Sep  2 02:07:31 2019

@author: user
"""
import numpy as np
import gym
import random
import time
from IPython.display import clear_output
from utilites import plotLearning
from frozenLake_Q import Agent

class Reinforce_frozenLake_Q():
    def __init__(self,  max_steps_per_episode=100):
        #the max number of steps our agent can take in a single episode
        #if the episode didn't termonate by reaching a final step
        #then the episode will terminate after 100 step no matter what
        self.max_steps_per_episode= max_steps_per_episode
        #self.env= env
        
    def train(self):
        env= gym.make("FrozenLake-v0")
        action_space_size= env.action_space.n 
        #actions
        state_space_size= env.observation_space.n 
           #total number of episodes we 
        #want our agent to play during training
        num_episodes=10000
        #alpha
        learning_rate=0.01
        #gamma
        discount_rate=0.99
        
        #epsilon 
        exploration_rate=1
        max_exploration_rate=1
        min_exploration_rate=0.01
        #the rate at which the exploration rate will decay
        exploration_decay_rate=0.001
        Q= np.zeros((state_space_size, action_space_size))
        
        agent= Agent(action_space_size, state_space_size,
              num_episodes, self.max_steps_per_episode, learning_rate,
              discount_rate, exploration_rate,max_exploration_rate,
              min_exploration_rate, exploration_decay_rate)
        for i in range(5):
            Q, scores, epsilons= agent.learn(Q)
            
        filename= "frozenLake.png"
        plotLearning( scores, filename=filename, window= 500)
        return Q
    
    
    