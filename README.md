# TriangleFinder

The project is an NancyFx web service hosted in and ASP.NET environment. The target is .NET 4.5 runtime. It should be able to be run right out of Visual Studio.

Project structure:
1. It consists of the NancyFx web service that will:
    * Create the grid based on row/columns
    * Get the grid based on id
    * Find the triangle in the grid based on the vertices provided
2. Web page
    * Display the grid to a canvas(based on the results of the web service call)
    * Inputs to lookup the triangle at the coordinates provided. 

## Description
Given a number of rows and columns, createa a grid structure that consists of right triangles where they form a square.

There will be 6 rows (A - F) and 12 columns (1 - 12). Each row will consist of 12 triangles with each triangle representing a column.

Row:
```
    A1\A2 A3\A4 A5\A5 A7\A8 A9\A10 A11\A12
```

Given that each non-hypotenuse side of the tiriangle is 10px, draw the grid created based on the dimensions above. It will result in a visual grid that is 60px x 60px and consist of 72 triangles.

After that is displayed, provide a way to find a specific triangle given its set of vertices.

e.g.
```
 V2(x,y)
        |\
        | \
        |  \
        |___\
 V1(x, y)    V3(x,y)
```

So for a triangle Row A Column 2:
```
            
     (0,0)  _____  (1,0)
            \   |
             \  |
              \ |
               \|
           (1, 1)    
```

The triangle found at : V1 (1, 1), V2 (0,0), V3 (1, 0)

Would be: **A2**

