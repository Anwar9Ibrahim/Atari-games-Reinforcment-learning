# -*- coding: utf-8 -*-
"""
Created on Mon Sep  2 22:20:03 2019

@author: user
"""
import numpy as np 
import matplotlib.pyplot as plt 


class utilities_Q():
    def __init__(self):
        self.MAXSTATES = 10**4
    #max dict is an utility function that iterates through a Q-table and tells u what the max-key and max-values are, we use this in finding the maximum elements of the 
    #Q-array, because that's how Q-learning works
    def max_value_in_table(self,d):
        max_value = float('-inf')
        for key, val in d.items():
            if val > max_value:
                max_value = val
                max_key = key
        return max_key, max_value
    
    
    
    #first we have to solve how to go from a continous space to discrete space, fourtunally numpy has some built in functions 
    #that can make that quite simple#so we have first created an array of zeroes 4x10 because we are gonna go with four different quantaites
    #and it's gonna be placed into one bit or another
    def create_bins(self):
        # obs[0] -> cart position --- -4.8 - 4.8
        # obs[1] -> cart velocity --- -inf - inf
        # obs[2] -> pole angle    --- -41.8 - 41.8
        # obs[3] -> pole velocity --- -inf - inf
    
        bins = np.zeros((4,10))
        #first we took the position and put it into its own linear space and likewise for the other variables
        #and for the velocity they can be +inf and -inf but we put +5 or -5
        #if we want to do this scientifically, we would run the simulation a whole bunch of times, and keep track of a history of the
        #distrubution of velocity and then loop it off on the two ends, we just went on and put-5 good enugh for demonstration perpuses
        bins[0] = np.linspace(-4.8, 4.8, 10)
        bins[1] = np.linspace(-5, 5, 10)
        bins[2] = np.linspace(-.418, .418, 10)
        bins[3] = np.linspace(-5, 5, 10)
    
        return bins
    
    #for a given state what bin does it fall into, fourtunatlly numpy has a nother function digitize
    #where you pass it the number, and a set of bins (in our case four different bins to four different quantity)
    #so it will tell you which bin that quantaty falls in, so it converts it from a continous varable to a discrete 
    #variable
    def assign_bins(self,observation, bins):
        state = np.zeros(4)
        for i in range(4):
            state[i] = np.digitize(observation[i], bins[i])
        return state
    
    
    
    #encoding the states as strings, because it made more sinse to havethe keys of the dictunary"q_table"
    #to be strings, and we dont have to do this integers can serve the same pourpus as well, but here this is how we are gonna do it
    #getting all the states there is 10000 different states but state 1 you don't want it to be 1 singelton, because that's not what we really mean 
    # we mean 0001, the position, velocity, pole angle all being zero bins, and the pole velocity of the tip is in the first bin
    #and that's why we use the function Zfill, which will add the remaining  three zeros, the 4 will tell us how many digits we have, while the first number 1 will tell 
    #us what is the value of the first bins
    def state_as_string(self,state):
        state_string = ''.join(str(int(e)) for e in state)
        return state_string
    
    #and this is how we encode all the states as strings
    def all_states_string(self):
        states = []
        for i in range(self.MAXSTATES):
            states.append(str(i).zfill(4))
        return states
    
    #we have a utility function to plot the runnng average it just creats an empty array, and itterates through it
    #and takes the average of the last 100 games, and plots it out
    def plot_running_avg(self, totalrewards, filename, x=None, window=5):
        
        #def plotLearning(scores, filename, x=None, window=5):   
        N = len(totalrewards)
        running_avg = np.empty(N)
        for t in range(N):
    	    running_avg[t] = np.mean(totalrewards[max(0, t-window):(t+1)])
        if x is None:
            x = [i for i in range(N)]
        plt.ylabel('Score')       
        plt.xlabel('Game')                     
        plt.plot(x, running_avg)
        plt.Show();
        plt.savefig(filename)
        '''
        N = len(totalrewards)
        running_avg = np.empty(N)
        for t in range(N):
            running_avg[t] = np.mean(totalrewards[max(0, t-100):(t+1)])
        #plt.plot(totalrewards)
        plt.plot(running_avg)
        plt.title("Running Average")
        plt.xlabel('Episode')
        plt.ylabel('Reward')

        plt.show()
        plt.savefig(filename)
        
     
    if x is None:
        x = [i for i in range(N)]
    plt.ylabel('Score')       
    plt.xlabel('Game')                     
    plt.plot(x,running_avg )
    
    print("Episode", len(scores), "\n", \
      window, "episode moving avg:", running_avg[-1])
    
    plt.savefig(filename)
    '''

