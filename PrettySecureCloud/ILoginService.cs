﻿using System.ServiceModel;

namespace PrettySecureCloud
{
	[ServiceContract]
	public interface ILoginService
	{
		[OperationContract]
		bool UsernameUnique(string username);

		[OperationContract]
		void Register(string username, string mail, string password);

		[OperationContract]
		User Login(string username, string password);

		[OperationContract]
		void Update(User newUserData);
	}
}