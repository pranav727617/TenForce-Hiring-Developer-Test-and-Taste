# TenForce-Hiring-Developer-Test-and-Taste
Exercise part 2
Notice that the performance of this application is suboptimal. Propose in less than 5 lines an alternative
solution to this problem (if possible) and explain a benefit and a drawback versus the solution that you
have chosen:

Answer: Solution - Calculate Average Gravity of Moon of each planet at the start and save it. When required use the saved value and not recalculate it again.
        Benefit - Code will run faster because it doesnt have to perform Math operations repeatedly
        Drawback - Extra memory will be used to save result of average of moon gravity. If moon data changes, will have to update the moon data in saved result as well.
