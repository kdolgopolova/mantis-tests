﻿using System;

namespace mantis_tests
{
    public class ProjectData : IEquatable<ProjectData>, IComparable<ProjectData>
    {
        public ProjectData()
        {

        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Id { get; set; }

        public bool Equals(ProjectData other)
        {

            if (Object.ReferenceEquals(other, null))
            {
                return false;

            }

            if (Object.ReferenceEquals(this, other))
            {
                return true;

            }
            return Name == other.Name;
        }

        public override string ToString()
        {
            return $"name: {Name}, Desc: {Description}";
        }

        public int CompareTo(ProjectData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return 1;
            }
            return Name.CompareTo(other.Name);
        }
    }
}