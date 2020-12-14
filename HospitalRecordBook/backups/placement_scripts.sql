SET IDENTITY_INSERT [dbo].[Specializations] ON 
GO
INSERT [dbo].[Specializations] ([SpecializationID], [SpecializationName]) VALUES (1, N'Neurologists')
GO
INSERT [dbo].[Specializations] ([SpecializationID], [SpecializationName]) VALUES (2, N'Dermatologists')
GO
INSERT [dbo].[Specializations] ([SpecializationID], [SpecializationName]) VALUES (3, N'Psychiatrists')
GO
INSERT [dbo].[Specializations] ([SpecializationID], [SpecializationName]) VALUES (4, N'Dentists')
GO
INSERT [dbo].[Specializations] ([SpecializationID], [SpecializationName]) VALUES (5, N'ENT')
GO
SET IDENTITY_INSERT [dbo].[Specializations] OFF
GO
SET IDENTITY_INSERT [dbo].[Doctors] ON 
GO
INSERT [dbo].[Doctors] ([DoctorID], [DoctorName], [Gender], [Degree], [SpecializationID], [Fee]) VALUES (1, N'Dr. P.S. Gill', N'Male', N'B.D.S', 4, 96.50)
GO
INSERT [dbo].[Doctors] ([DoctorID], [DoctorName], [Gender], [Degree], [SpecializationID], [Fee]) VALUES (2, N'Dr. J. Asthana', N'Male', N'B.D.S', 4, 95.10)

GO
INSERT [dbo].[Doctors] ([DoctorID], [DoctorName], [Gender], [Degree], [SpecializationID], [Fee]) VALUES (3, N'Dr. Simran Kaur', N'Female', N'M.B.B.S.', 1, 85.20)

GO
INSERT [dbo].[Doctors] ([DoctorID], [DoctorName], [Gender], [Degree], [SpecializationID], [Fee]) VALUES (4, N'Dr. Monika Singh', N'Female', N'M.D.', 2, 73.00)

GO
INSERT [dbo].[Doctors] ([DoctorID], [DoctorName], [Gender], [Degree], [SpecializationID], [Fee]) VALUES (5, N'Dr. Manish Goyal', N'Male', N'P.D.M', 3, 50.50)

GO
INSERT [dbo].[Doctors] ([DoctorID], [DoctorName], [Gender], [Degree], [SpecializationID], [Fee]) VALUES (6, N'Dr. Rohit Maggo', N'Male', N'M.D.', 5, 100.00)

GO
INSERT [dbo].[Doctors] ([DoctorID], [DoctorName], [Gender], [Degree], [SpecializationID], [Fee]) VALUES (7, N'Dr. M. L. Talwar', N'Male', N'M.S.', 5, 100.00)

GO
INSERT [dbo].[Doctors] ([DoctorID], [DoctorName], [Gender], [Degree], [SpecializationID], [Fee]) VALUES (8, N'Dr. Neha Sharma', N'Female', N'M.B.B.S.', 5, 110.00)




GO
SET IDENTITY_INSERT [dbo].[Doctors] OFF
GO
SET IDENTITY_INSERT [dbo].[Patients] ON 
GO
INSERT [dbo].[Patients] ([PatientID], [PatientName], [Gender], [Phone], [Age]) VALUES (1, N'Mukul Singh',N'Male',647230280,25)
GO
INSERT [dbo].[Patients] ([PatientID], [PatientName], [Gender], [Phone], [Age]) VALUES (2, N'Akhil Jaiswal',N'Male',647214380,23)

GO
INSERT [dbo].[Patients] ([PatientID], [PatientName], [Gender], [Phone], [Age]) VALUES (3, N'Parmeet Singh',N'Male',647217680,32)
GO
INSERT [dbo].[Patients] ([PatientID], [PatientName], [Gender], [Phone], [Age]) VALUES (4, N'Saloni Gupta',N'Female',643210876,18)
GO
SET IDENTITY_INSERT [dbo].[Patients] OFF
GO
SET IDENTITY_INSERT [dbo].[Appointments] ON 
GO
INSERT [dbo].[Appointments] ([AppointmentID], [AppointmentTitle], [Description], [PatientID]) VALUES (1, N'Normal', N'Unable to focus on far objects', 1)
GO
INSERT [dbo].[Appointments] ([AppointmentID], [AppointmentTitle], [Description], [PatientID]) VALUES (2, N'Emergency', N'Sever pain in tooth cavity', 2)
GO
INSERT [dbo].[Appointments] ([AppointmentID], [AppointmentTitle], [Description], [PatientID]) VALUES (3, N'Emergency', N'Sever heahache every night from past 4 days', 4)

GO
SET IDENTITY_INSERT [dbo].[Appointments] OFF
GO