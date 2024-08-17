//*****************************************************************************
//** 1937. Maximum Number of Points with Cost   leetcode                     **
//** This was not the final code that worked, I had to add left and right to **
//** find the distance.  it was tricky, so I'm not providing that solution   **
//*****************************************************************************

long long maxPoints(int** points, int pointsSize, int* pointsColSize) {
    long long maxPoints = 0;
    int prevPos = -1;
    int pos = 0;
    for(int i = 0; i < pointsSize; i++)
    {
        int max = -1;
        pos = 0;
        for(int j = 0; j < pointsColSize[i]; j++)
        {
            if(max < points[i][j])
            {
                max = points[i][j];
                pos = j;
            }
        }

        if(prevPos != -1)
        {
            int diff = abs(pos - prevPos);
            maxPoints = maxPoints + max - diff;
        }
        else
        {
            maxPoints = maxPoints + max;
        }
        prevPos = pos;
    }
    return maxPoints;
}