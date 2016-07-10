# Girl Life - ECV: Contribution Guide

## Branches

*master*  - This is where we develop most of the game.

*release* - Current release bug fix.

## Remember

- Try to keep the game playable ... always. Bugs will happen but obvious mistakes can be eliminated in a simple testing run.
- **Be careful! Do not erase other people work.**
    - Git offer some help with that but sometimes we have to resolve conflicts ourselves.
- Try to make **meaningful** commit messages.
    - You can use emojis like: :wrench:, :up:, :recycle:, :new:, :x:, :shower:. Just dont overload :smile:
    - emoji cheat sheet: http://www.emoji-cheat-sheet.com/
- Commit **often** and in **small** chunks. 
    - If revert is needed we don't lose much.

### How to contribute?

- Fork our repository clicking that "fork" button near the star button above.
- **Read the code** to see how we do things.
- Make your changes.
- Submit merge requests.

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

### Using SourceTree client to manage your fork.

- Download and install SourceTree (https://www.sourcetreeapp.com/). Let it install everything.
- Create your own fork of project if you haven't already. 
- Go to the project tab of your fork and copy SSH/HTTP link there.
- Run SourceTree and Clone/New button. Paste in the SSH/HTTP link of your fork. You will probably get a prompt to log into GitLab. Do so. Project files will be copied to your drive.
- You search and edit files in working copy. 
- Since files in /location have no extension its best to open them using custom actions. Tools/Options/Custom actions. Enter $FILE in parameters and link to your text editor of choice in scripts. Will need to restart SourceTree for new actions to become available.
- Commits you make will not appear on your project web page until you Push them.
- To sync your fork with main fork when there are new commits go to Repository/Repository Settings in SourceTree menu bar and click add. Enter ssh://git@git.tfgamessite.com:9000/mjsmagalhes/girllife-ecv.git (or http://) into Url/Path. Name it whatever you want. Once that is done click Pull button and select it from the dropdown list. Your fork will be updated.