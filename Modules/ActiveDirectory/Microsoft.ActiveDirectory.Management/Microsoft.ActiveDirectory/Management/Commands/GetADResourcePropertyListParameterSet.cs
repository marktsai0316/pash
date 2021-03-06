using Microsoft.ActiveDirectory.Management;
using System;
using System.Management.Automation;

namespace Microsoft.ActiveDirectory.Management.Commands
{
	public class GetADResourcePropertyListParameterSet : ADParameterSet
	{
		[Parameter]
		public ADAuthType AuthType
		{
			get
			{
				return (ADAuthType)base["AuthType"];
			}
			set
			{
				base["AuthType"] = value;
			}
		}

		[Credential]
		[Parameter]
		[ValidateNotNullOrEmpty]
		public PSCredential Credential
		{
			get
			{
				return base["Credential"] as PSCredential;
			}
			set
			{
				base["Credential"] = value;
			}
		}

		[Parameter(Mandatory=true, ParameterSetName="Filter", HelpMessageBaseName="Microsoft.ActiveDirectory.Management", HelpMessageResourceId="ADUserFilterHM")]
		[TransformFilter]
		[ValidateNotNullOrEmpty]
		public string Filter
		{
			get
			{
				return base["Filter"] as string;
			}
			set
			{
				base["Filter"] = value;
			}
		}

		[Parameter(Mandatory=true, Position=0, ValueFromPipeline=true, ParameterSetName="Identity")]
		[ValidateNotNull]
		[ValidateNotNullOrEmptyADEntity]
		public ADResourcePropertyList Identity
		{
			get
			{
				return base["Identity"] as ADResourcePropertyList;
			}
			set
			{
				base["Identity"] = value;
			}
		}

		[Parameter(Mandatory=true, ParameterSetName="LdapFilter")]
		[ValidateNotNullOrEmpty]
		public string LDAPFilter
		{
			get
			{
				return base["LDAPFilter"] as string;
			}
			set
			{
				base["LDAPFilter"] = value;
			}
		}

		[Alias(new string[] { "Property" })]
		[Parameter]
		[ValidateNotNullOrEmpty]
		public string[] Properties
		{
			get
			{
				return base["Properties"] as string[];
			}
			set
			{
				base["Properties"] = value;
			}
		}

		[Parameter(ParameterSetName="Filter")]
		[Parameter(ParameterSetName="LdapFilter")]
		[ValidateNotNullOrEmpty]
		[ValidateRange(0, 0x7fffffff)]
		public int ResultPageSize
		{
			get
			{
				return (int)base["ResultPageSize"];
			}
			set
			{
				base["ResultPageSize"] = value;
			}
		}

		[Parameter(ParameterSetName="LdapFilter")]
		[Parameter(ParameterSetName="Filter")]
		[ValidateNullableRange(1, 0x7fffffff)]
		public int? ResultSetSize
		{
			get
			{
				return (int?)(base["ResultSetSize"] as int?);
			}
			set
			{
				base["ResultSetSize"] = value;
			}
		}

		[Parameter]
		[ValidateNotNullOrEmpty]
		public string Server
		{
			get
			{
				return base["Server"] as string;
			}
			set
			{
				base["Server"] = value;
			}
		}

		public GetADResourcePropertyListParameterSet()
		{
		}
	}
}