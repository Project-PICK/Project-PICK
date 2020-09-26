<img src="https://octodex.github.com/images/stormtroopocat.jpg" width="250">


## 🤚Git Workflow Checklist
## Initial Steps:
> - [✅] **Fork** the project repository into your personal Github

<img width="290" alt="Screen Shot 2020-09-25 at 9 51 29 PM" src="https://user-images.githubusercontent.com/68033681/94330477-f123c380-ff79-11ea-9ab6-8a793eb6277b.png">

> - [✅] **Clone** the repository from your fork into your folder for editing

<img width="330" alt="Screen Shot 2020-09-25 at 10 05 06 PM" src="https://user-images.githubusercontent.com/68033681/94330639-2e3c8580-ff7b-11ea-9032-240cad558a39.png">

```
git clone https://github.com/ptoulino/Project-PICK.git
```
***

## Development:

> - [✅] **SYNC FORK** 🤚 Make sure your personal repository is all synced with the project


<img width="350" alt="Screen Shot 2020-09-25 at 10 09 19 PM" src="https://user-images.githubusercontent.com/68033681/94330804-98a1f580-ff7c-11ea-82a9-1115b85401a4.png">

<img width="350" alt="Screen Shot 2020-09-25 at 10 11 55 PM" src="https://user-images.githubusercontent.com/68033681/94330803-9770c880-ff7c-11ea-97b8-268d7681e2a3.png">


<img width="350" alt="Screen Shot 2020-09-25 at 10 16 30 PM" src="https://user-images.githubusercontent.com/68033681/94330842-d99a0a00-ff7c-11ea-9a84-24b889d6c913.png">

```
cd folder_name
git pull
```

> - [✅] **Edit** changes to code, add files for staging

```
git add folder_name //or
git add file_name  //or
git add . //Adds all edited files in folder that has been repoed
```

> - [✅] Use git to add commited files following **conventional commit format style**

>> - [✅] **Push** code into personal repository

```
git commit -m "feat(forms): Product Functions - Login" -m "Closes #843" //or simply
git commit -m "feat(forms): Product Functions - Login"
git push
```

> - [✅] 🤚 **Create pull request** to main project repository and add appropriate labels for merge

<img width="235" alt="Screen Shot 2020-09-25 at 10 52 02 PM" src="https://user-images.githubusercontent.com/68033681/94331528-00a70a80-ff82-11ea-8e5a-13abd71f52b5.png">


***



+ [More information on Git](https://dont-be-afraid-to-commit.readthedocs.io/en/latest/git/commandlinegit.html) 
***

## 📑 Team Checklist:

- [✅] *Find database that fits project*
- [✅] *Continuously update [SRS](https://docs.google.com/document/d/1lbW62LPh84QcCzgn3-WpvVLJhuLZc-Fj-svnL28oMaM/edit) documentation*
- [ ] **Brainstorm and apply features we want in our application**
- [ ] **Brainstorm specific courses/scenarios for user training**
- [✅] Git documentation(*how we go about pushing code (branches) and our agreed commit structure*)
- [ ] **Discuss possible CI/CD implementation**
***

## 🔖 Links

>  + [Discord](https://discord.gg/NJmaeD)
>  + [Google Doc](https://docs.google.com/document/d/1lbW62LPh84QcCzgn3-WpvVLJhuLZc-Fj-svnL28oMaM/edit)
>  + [ZOOM Meeting Link](https://humboldtstate.zoom.us/j/7200172984)
***
 **Commit Message Tools**
>  - [Auto-Changelog](https://www.npmjs.com/package/auto-changelog)
>  - [Commitizen](https://www.npmjs.com/package/commitizen)

## ⚙️Git™ Conventional Commit Format

<pre>
<b><a href="#types">&lt;type&gt;</a></b></font>(<b><a href="#scopes">&lt;optional scope&gt;</a></b>): <b><a href="#subject">&lt;subject&gt;</a></b>
<sub>empty separator line</sub>
<b><a href="#body">&lt;optional body&gt;</a></b>
<sub>empty separator line</sub>
<b><a href="#footer">&lt;optional footer&gt;</a></b>
</pre>


### Examples:
* ```
  feat(shopping cart): adding the amazing button
  ```
* ```
  fix: add missing parameter to service call
  
  The error occurred because of <reasons>.
  ```
* ```
  build: release version 1.0.0
  ```
* ```
  refactor: implement calculation method as recursion
  ```
* ```
  style: remove empty line
  ```
* ```
  revert: refactor: implement calculation method as recursion
  
  This reverts commit 221d3ec6ffeead67cee8c730c4a15cf8dc84897a.
  ```
* ```
  feat: remove ticket list endpoint
  
  refers to JIRA-1337
  BREAKING CHANGES: ticket enpoints no longer supports list all entites.
  ```

***

## 🏁 Important Dates

| 	⌛ Due Dates | Requirements | Percentage |
| ------ | ----------- |-------- |
| ~~09/23~~   | ~~Software Requirement Specification-Sprint 1~~ |~~**6%**~~ |
| **10/14** | Software Design Specification Sprint 2 (including User Interface design) |*4%* |
| 11/12    | Test Plan |*4%* |
| 12/02    | Demonstration of the software  |**10%**|
| 12/05    | User Manual |*3%* |
| 12/05    | Programmers’ manual |*3%* |
| Week 7 & 14| Peer Evaluation Week |`TBD`|
| Ongoing- Week 14 | Client Evaluation  |`TBD`|
***

## 🚦 Blockers
 
```diff
- Example problem I ran into
+ Example solution to the problem
```

***

## 🗿Current Software Requirements for Development
> + [VS Studio](https://visualstudio.microsoft.com/)
> + [Winforms introduction](https://www.youtube.com/watch?v=Oxg6ciIcO3U)
***

## 🧞Canvas Project Resources

> + [Project Rubric](https://canvas.humboldt.edu/courses/46023/files/2190442?module_item_id=822639)
>> + [Project Overview](https://canvas.humboldt.edu/courses/46023/pages/project-overview?module_item_id=740402)
> + [SRS Template](https://canvas.humboldt.edu/courses/46023/files/2042318?module_item_id=740405)
>> + [SRS **MUST** Haves](https://canvas.humboldt.edu/courses/46023/pages/srs-must-haves?module_item_id=740406)
> + [Design Specification Template](http://www.cs.iit.edu/~oaldawud/CS487/project/software_design_specification.htm)

