﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Simple.TaskManagement.DataTypes;

namespace Simple.TaskManagement.DataTypes.Mockups
{
    public class MockupTasks
    {

        public Simple.TaskManagement.DataTypes.Task[] TaskList => AdvancedTaskList();

        #region Advanced task list

        Simple.TaskManagement.DataTypes.Task[] AdvancedTaskList() => new DataTypes.Task[]
        {
            Analysis,
            Research,
            Prototype,
            Develop,
            Market
        }
        .Select((x, n) => { x.TaskId = $"#{n}"; return x; })
        .ToArray();


        #region Analysis
        DataTypes.Task Analysis { get; } = new DataTypes.Task()
        {


            TaskType = TaskType.Analysis,
            TaskStatus = TaskStatus.Completed,

            RequiredByDate = DateTime.Parse("2017-01-01"),

            TaskDescription = "The concept of T14 was born",

            AssignedTo = new List<Contact>(new Contact[] { new Contact() { Id = "applicant@abv.bg" } }),

            Comments = new List<Comment>(new Comment[]
            {
                 new Comment()
                    {
                        Number = "1.",
                        CommentType = CommentType.Item,
                        ReminderDate = DateTime.Now.AddDays(3),
                        Commentary = "Analyze the task."
                    },


                 new Comment()
                    {
                     Number = "2.",
                        CommentType = CommentType.Item,
                        ReminderDate = DateTime.Now.AddDays(-3),
                        Commentary = "Understand the problem area."
                    },



                new Comment()
                    {
                    Number = "3.",
                        CommentType = CommentType.Item,
                        ReminderDate = DateTime.Now.AddDays(-3),
                        Commentary = "Examine existing solutions."
                    },




                 new Comment()
                    {
                    Number = "4.",
                        CommentType = CommentType.Item,
                        ReminderDate = DateTime.Now.AddDays(-3),
                        Commentary = "Evaluate available resources."
                    },


                 new Comment()
                    {
                    Number = "4.1",
                        CommentType = CommentType.Item,
                        ReminderDate = DateTime.Now.AddDays(-3),
                        Commentary = "such as time"
                    },

                new Comment()
                    {
                        CommentType = CommentType.Item,
                        ReminderDate = DateTime.Now.AddDays(-3),
                        Commentary = "such as time",
                    },

            })
        };
        #endregion

        #region Research
        DataTypes.Task Research { get; } = new DataTypes.Task()
        {


            TaskType = TaskType.Analysis,

            RequiredByDate = DateTime.Parse("2017-01-01"),

            TaskDescription = "Research, Research, Research existing solutions.",

            AssignedTo = new List<Contact>(new Contact[] { new Contact() { Id = "applicant@abv.bg" } }),


            Comments = new List<Comment>(new Comment[]
        {
                new Comment()
                    {
                        Number = "1",
                        CommentType = CommentType.Item,
                        ReminderDate = DateTime.Now.AddDays(-3),
                        Commentary = @"Simple task management systems."
                    },


                    new Comment()
                    {
                        Number= "1.1",
                        CommentType = CommentType.Item,
                        ReminderDate = DateTime.Now.AddDays(-3),
                        Commentary = @"Simple task management systems i.e. 
                                       http://www.capterra.com/task-management-software/ 
                                     ."
                    },


                    new Comment()
                    {
                        Number="1.2",
                        CommentType = CommentType.Item,
                        ReminderDate = DateTime.Now.AddDays(-3),
                        Commentary = @"Simple task management systems i.e. 
                                      https://xbsoftware.com/case-studies-webdev/project-management-tool-for-communications-portal/."
                    },



                    new Comment()
                    {
                        Number = "2.",
                        CommentType = CommentType.Item,
                        ReminderDate = DateTime.Now.AddDays(-3),
                        Commentary = "Cool 'TODO' apps at https://zapier.com/blog/best-todo-list-apps/"
                    },


                    new Comment()
                    {
                        Number = "2.1",
                        CommentType = CommentType.Item,
                        ReminderDate = DateTime.Now.AddDays(-3),
                        Commentary = "Remember the milk https://zapier.com/blog/best-todo-list-apps/#remember"
                    },


                    new Comment()
                    {
                     Number = "2.2",
                        CommentType = CommentType.Item,
                        ReminderDate = DateTime.Now.AddDays(-3),
                        Commentary = "Everyday https://zapier.com/blog/best-todo-list-apps/#everyday"
                    }
        })};
        #endregion

        #region Prototype
        DataTypes.Task Prototype { get; } = new DataTypes.Task()
        {

            TaskType = TaskType.Prototype,

            RequiredByDate = DateTime.Parse("2017-01-01"),

            TaskDescription = "Developed prototypes.",

            AssignedTo = new List<Contact>(new Contact[] { new Contact() { Id = "applicant@abv.bg" } }),

            Comments = new List<Comment>(new Comment[]
            {
                new Comment()
                    {
                    Number = "1.",
                        CommentType = CommentType.Item,
                        ReminderDate = DateTime.Now.AddDays(-3),
                        Commentary = @"Developed very first prototypes were developed."
                    },

                new Comment()
                    {
                        Number = "1",
                        CommentType = CommentType.Note,
                        ReminderDate = DateTime.Now.AddDays(-3),
                        Commentary = @"The very first prototypes were developed."
                    }
        })
        };
        #endregion

        #region Develop
        DataTypes.Task Develop { get; } = new DataTypes.Task()
        {


            TaskType = TaskType.Develop,

            RequiredByDate = DateTime.Parse("2017-01-01"),

            TaskDescription = "Developed Project.",

            AssignedTo = new List<Contact>(new Contact[] { new Contact() { Id = "applicant@abv.bg" } }),

            Comments = new List<Comment>(new Comment[]
            {
                 new Comment()
                    {
                        Number = "1.",
                        CommentType = CommentType.Item,
                        ReminderDate = DateTime.Now.AddDays(-3),
                        Commentary = @"Developing some of the core software features."
                    },

                new Comment()
                    {
                        Number = "2.",
                        CommentType = CommentType.Note,
                        ReminderDate = DateTime.Now.AddDays(-3),
                        Commentary = @"Develop the rest."
                    }
            })
        };
        #endregion

        #region Market
        DataTypes.Task Market { get; } = new DataTypes.Task()
        {

            TaskId = "C# Task#1",

            TaskType = TaskType.Market,

            RequiredByDate = DateTime.Parse("2017-01-01"),

            TaskDescription = "Invent a good name for the product.",

            AssignedTo = new List<Contact>(new Contact[] { new Contact() { Id = "applicant@abv.bg" } }),

            Comments = new List<Comment>(new Comment[]
            {
                new Comment()
                    {
                        Number = "1.",
                        CommentType = CommentType.Item,
                        ReminderDate = DateTime.Now.AddDays(-3),
                        Commentary =
                    @"The code name T14 comes from а game of words
                        Task for Task-ing
                        аnd
                        the popular T4 template feature.
                        The 'T14-probable-system' is the name automatically generated by git,
                        вhich began to appeal to me in time."
                    },

                new Comment()
                    {
                    Number = "2.",
                        CommentType = CommentType.Item,
                        ReminderDate = DateTime.Now.AddDays(-3),
                        Commentary = @"Invent a good name for the product."
                    }


            })
        };
        #endregion

        #endregion

        #region Task Types
        public IEnumerable<TaskType> TaskTypes
        {
            get
            {
                return Enum.GetValues(typeof(TaskType))
                    .OfType<TaskType>();
            }
        }
        #endregion

        #region Task Types
        public IEnumerable<TaskStatus> TaskStatuses
        {
            get
            {
                return Enum.GetValues(typeof(TaskStatus))
                    .OfType<TaskStatus>();
            }
        }
        #endregion
    }
}
