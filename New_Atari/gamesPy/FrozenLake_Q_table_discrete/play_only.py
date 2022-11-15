# -*- coding: utf-8 -*-
"""
Created on Tue Sep  3 09:50:04 2019

@author: user
"""

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
    Q= np.array([(0.54919533, 0.52196401, 0.52473841, 0.52015219),(0.33390074, 0.2949932 ,0.28139371 ,0.49452331)
                    ,(0.37688266, 0.38662249, 0.35391735, 0.46197831),(0.25169029, 0.20985681, 0.22132339, 0.45004066),
                    (0.56564004,0.36978195,0.41602894,0.39500102),(0.         ,0.        ,0.        ,0.        ),
                    (0.38571393,0.18946194,0.29482991,0.11343747),(0.        ,0.        ,0.        ,0.        ),
                    (0.40278837,0.41407288,0.4033959 ,0.60009506),(0.41675408,0.65417247,0.458007  ,0.4017365),
                    (0.6379315,0.4574877,0.37145218,0.3164539),(0.        ,0.        ,0.        ,0.        ),
                    (0.        ,0.        ,0.        ,0.        ),(0.45006792,0.49236841,0.76227469,0.53748479),
                    (0.73257176,0.88483948,0.8196049,0.77642171),(0.        ,0.        ,0.        ,0.        )])
    print(Q)
    wins=0
    played= 2
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
