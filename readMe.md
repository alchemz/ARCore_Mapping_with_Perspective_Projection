## Mapping
1. instead of using GPS or SLAM, we can place four anchor points to form the mapping system. 
* P1(0, 0, 0), P2(x, 0, 0), P3(0, y, 0,), P4(0, 0, Z)
* notes: arcore cannot measure height now
* yet we found that different plans are colored differently, so potentially, we could detect different planes and also detect the wall by calculating the plane perpendicularly. 

2. Todo
* Use ARcore to measure the space
* reference: https://stackoverflow.com/questions/45982196/how-to-measure-distance-using-arcore

3. Demo
![alt text](https://github.com/alchemz/ARCore-Unity-Mapping/blob/master/demo.png)

4. Measure Length parallel to the ground(known)

5. Measure height perpendicular to the ground(unknown)
* a potential solution:
![alt text](https://github.com/alchemz/ARCore-Unity-Mapping/blob/master/measure_height_concept.png)
