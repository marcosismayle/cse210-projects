"""
Assignment: W01 Prove: Developer
File: tic-tac-toe.py
Author: Marcos Ismayle
Purpose: Tic-Tac-Toe is a game in which two players seek in alternate turns to complete a row, a column,
or a diagonal with either three x's or three o's drawn in the spaces of a grid of nine squares.
"""

# imports

import os
import random
from colorama import Fore

# Global variables

play_again = 'y'
turns = 0
player = 2 # CPU = Player 1 and user = Player 2
max_turns = 9
win = 'n'
grid = [
    [' ', ' ', ' '],
    [' ', ' ', ' '],
    [' ', ' ', ' ']
]

def main():
    global grid
    global turns
    os.system('cls')
    print(f'''        0   1   2
    0:  {grid[0][0]} | {grid[0][1]} | {grid[0][2]}
       ------------
    1:  {grid[1][0]} | {grid[1][1]} | {grid[1][2]}
       ------------
    2:  {grid[2][0]} | {grid[2][1]} | {grid[2][2]}
    ''')
    print('Turns: ' + Fore.GREEN + str(turns) + Fore.RESET)

def user_play():
    global turns
    global player
    global max_turns

    if player == 2 and turns < max_turns:

        try:
            l = int(input('Line..: '))
            c = int(input('Columm..: '))
            while grid[l][c] != ' ':
                l = int(input('Line..: '))
                c = int(input('Columm..: '))
            grid[l][c] = 'X'
            player = 1
            turns += 1
        except:
            print('Invalid, try again.')
            os.system('pause')

def cpu_play():
    global turns
    global player
    global max_turns
    if player == 1 and turns < max_turns:
        l = random.randrange(0,3)
        c = random.randrange(0,3)
        while grid[l][c] != ' ':
            l = random.randrange(0,3)
            c = random.randrange(0,3)
    grid[l][c] = 'O'
    turns += 1
    player = 2

def winner():
    global grid
    win = 'n'
    symbols = ['X', 'O']
    for s in symbols:
        win = 'n'
        # look lines
        il=ic=0
        while il < 3:
            sum = 0
            ic = 0 
            while ic < 3:
                if(grid[il][ic]) == s:
                    sum += 1
                ic += 1

            if(sum == 3):
                win = s
                break
            il += 1
        if(win != 'n'):
            break

        # look collum

        il=ic=0
        while ic < 3:
            sum = 0
            il = 0 
            while il < 3:
                if(grid[il][ic]) == s:
                    sum += 1
                il += 1

            if(sum == 3):
                win = s
                break
            ic += 1
        if(win != 'n'):
            break

        # look diagonal 1

        sum = 0
        idiagl = 0
        idiagc = 2
        while idiagc >= 0:
            if(grid[idiagl][idiagc] == s):
                sum += 1
            idiagl += 1
            idiagc -= 1
        if(sum == 3):
            win = s
            break
    return win

def redefine():
    global grid
    global turns
    global player
    global max_turns
    global win
    turns = 0
    player = 2 # CPU = Player 1 and user = Player 2
    max_turns = 9
    win = 'n'
    grid = [
        [' ', ' ', ' '],
        [' ', ' ', ' '],
        [' ', ' ', ' ']
    ]

while(play_again == 'y'): 
    while True:
        main()
        user_play()
        cpu_play()
        main()
        win = winner()
        if(win != 'n') or (turns >= max_turns):
            break
    
    print(Fore.RED + 'GAME OVER' + Fore.YELLOW)
    if(win == 'X' or win == 'O'):
        print('Player ' + win + ' won')
    else:
        print('DRAW GAME')
    play_again = input(Fore.BLUE + 'Play again? [y/n]: ' + Fore.RESET)
    redefine()