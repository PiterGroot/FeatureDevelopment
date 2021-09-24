using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Path : MonoBehaviour
{
    [SerializeField]private Waypoint[] _wayPoints;

    public Waypoint GetPathStart() {
        return _wayPoints[0];
    }
    public Waypoint GetPathEnd() {
        return _wayPoints[_wayPoints.Length - 1];
    }
    public Waypoint GetNextWaypoint(Waypoint currentWaypoint) {
        int result = 0;
        int index = Array.IndexOf(_wayPoints, currentWaypoint);
        if(index + 1 < _wayPoints.Length) {
            result = index + 1;
        }
        else {
            return GetPathEnd();
        }
        return _wayPoints[result];

    }
}
