# -*- coding: utf-8 -*-
"""
Created on Mon Sep  2 22:30:07 2019

@author: user
"""
import gym
import numpy as np 
from utilities import utilities_Q

#next we come to the actuall Q-dictunary or Q-table
class Q_table_Con_to_discrete():
    def __init__(self):
        self.envName='CartPole-v0'
        
    def creatTable(self):
        util = utilities_Q()
        env = gym.make( self.envName)
        #first we initialize it to just an empty table
        Q = {}
        
        #and then we get all the states, next we are gonna loop over all the states
        all_states = util.all_states_string()
        #for a state in all states
        for state in all_states:
            #Q of state is just another empty dictunary/table
            Q[state] = {}
            #then we are gonna say that for each action, we are gonna assign the excpected reward to zero 
            for action in range(env.action_space.n):
                #we will have Q[sub_states][then for every action whether it is left or right] we will have a courresponding value
                # and here we initialized them all to zero but you can do any other random number it doesn't really matter
                Q[state][action] = 0
        return Q