# Girl Life - ECV: Contribution Guide

## Branches

*master*  - This is where we develop most of the game.

*release* - Current release bug fix.

## Remember

- Try to keep the game playable ... always. Bugs will happen but obvious mistakes can be eliminated in a simple testing run.
- Be careful! Do not erase other people work. 
    - Git offer some help with that but sometimes we have to resolve conflicts ourselves.
- Try to make **meaningful** commit messages.
    - You can use emojis like: :wrench:, :recycle:, :new:, :x:, :shower:. Just dont overload :smile:
    - emoji cheat sheet: http://www.emoji-cheat-sheet.com/
- Commit **often** and in **small** chunks. 
    - If revert is needed we dont loose much.

## Instructions

### SSH Keys

#### Windows:

To generate you SSH Key you may use **puttygen** (http://www.chiark.greenend.org.uk/~sgtatham/putty/download.html)  to generate them.

Open the program and follow:

- Make sure the middle option (SSH-2 RSA) in the bottom is marked.
- Make sure the number of bits in a generated key is 2048 (just below those options).
- Click generate and follow instructions.
- Copy the content in the big rectangle there.
- Go to your profile >> profile settings >> ssh keys and paste it in the key field (another big rectangle).
- Save the public key in a file.
- Save the private file.