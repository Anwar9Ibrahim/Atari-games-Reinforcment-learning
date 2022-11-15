# -*- coding: utf-8 -*-
"""
Created on Mon Sep  2 02:10:57 2019

@author: user
"""
import numpy as np
import gym
import random
import time
from IPython.display import clear_output
from utilites import plotLearning
from frozenLake_Q import Agent
from main_learn import Reinforce_frozenLake_Q

if __name__ == '__main__':
    
    env= gym.make("FrozenLake-v0")
    max_steps_per_episode= 100
    RL=Reinforce_frozenLake_Q(max_steps_per_episode= 100)
    Q= RL.train()
    wins=0
    played= 10
    for episode in range(played):
        state = env.reset()
        done= False
        print("********Episode ",episode+1, "*****\n\n\n\n")
        time.sleep(1)
        
        for step in range(max_steps_per_episode):
            clear_output(wait= True)
            env.render()
            time.sleep(0.03)
            
            action= np.argmax(Q[state,:])
            new_state, reward, done, info =env.step(action)
            
            if done:
                clear_output(wait=True)
                env.render()
                if reward == 1:
                    wins+=1
                    print("******you reasherd the goal*********")
                    time.sleep(1)
                else:
                    print("*****you fell throught a hole********")
                    time.sleep(1)
                clear_output(wait=True)
                break
        
            state=new_state
            
        print("you won", wins, "out of", played )
        
    env.close()
