using System;
using System.Reflection;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;
using Ouroboros.Core.Logging;

// Token: 0x02000139 RID: 313
[eiz("UR")]
[Serializable]
public sealed class a5g : a9q, ISerializable
{
	// Token: 0x060007A2 RID: 1954 RVA: 0x00020BBC File Offset: 0x0001EDBC
	private a5g(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.a = A_0.GetString("UR:FAN");
			this.b = A_0.GetString("UR:FTN");
			this.c = A_0.GetBoolean("UR:IR");
			this.d = (PropertyCollection)A_0.GetValue("UR:C", typeof(PropertyCollection));
			this.e = A_0.GetString("UR:N");
			return;
		}
		if (base.GetType() == typeof(a5g))
		{
			this.a = A_0.GetString("_FullAssemblyName");
			this.b = A_0.GetString("_FullTypeName");
			this.c = A_0.GetBoolean("_IsRequired");
			this.d = (PropertyCollection)A_0.GetValue("_Configuration", typeof(PropertyCollection));
			this.e = A_0.GetString("_Name");
			return;
		}
		this.a = A_0.GetString("UnitRef+_FullAssemblyName");
		this.b = A_0.GetString("UnitRef+_FullTypeName");
		this.c = A_0.GetBoolean("UnitRef+_IsRequired");
		this.d = (PropertyCollection)A_0.GetValue("UnitRef+_Configuration", typeof(PropertyCollection));
		this.e = A_0.GetString("UnitRef+_Name");
	}

	// Token: 0x060007A3 RID: 1955 RVA: 0x00020D28 File Offset: 0x0001EF28
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("UR:FAN", this.a);
		info.AddValue("UR:FTN", this.b);
		info.AddValue("UR:IR", this.c);
		info.AddValue("UR:C", this.d);
		info.AddValue("UR:N", this.e);
	}

	// Token: 0x060007A4 RID: 1956 RVA: 0x00020D8C File Offset: 0x0001EF8C
	public string f()
	{
		return this.a;
	}

	// Token: 0x060007A5 RID: 1957 RVA: 0x00020D94 File Offset: 0x0001EF94
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060007A6 RID: 1958 RVA: 0x00020DA0 File Offset: 0x0001EFA0
	public string c()
	{
		return this.b;
	}

	// Token: 0x060007A7 RID: 1959 RVA: 0x00020DA8 File Offset: 0x0001EFA8
	public void b(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060007A8 RID: 1960 RVA: 0x00020DB4 File Offset: 0x0001EFB4
	public bool d()
	{
		return this.c;
	}

	// Token: 0x060007A9 RID: 1961 RVA: 0x00020DBC File Offset: 0x0001EFBC
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060007AA RID: 1962 RVA: 0x00020DC8 File Offset: 0x0001EFC8
	public PropertyCollection e()
	{
		return this.d;
	}

	// Token: 0x060007AB RID: 1963 RVA: 0x00020DD0 File Offset: 0x0001EFD0
	public void a(PropertyCollection A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060007AC RID: 1964 RVA: 0x00020DDC File Offset: 0x0001EFDC
	public string y8()
	{
		return this.e;
	}

	// Token: 0x060007AD RID: 1965 RVA: 0x00020DE4 File Offset: 0x0001EFE4
	public void c(string A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060007AE RID: 1966 RVA: 0x00020DF0 File Offset: 0x0001EFF0
	public a5g()
	{
	}

	// Token: 0x060007AF RID: 1967 RVA: 0x00020E00 File Offset: 0x0001F000
	public a5g(string A_0, Type A_1, bool A_2)
	{
		this.e = A_0;
		this.f = A_1;
		this.c = A_2;
	}

	// Token: 0x060007B0 RID: 1968 RVA: 0x00020E28 File Offset: 0x0001F028
	public override string ToString()
	{
		return string.Concat(new string[]
		{
			"[Name: '",
			this.y8(),
			"', FullTypeName: ",
			this.c(),
			", FullAssemblyName: ",
			this.f(),
			", IsRequired: ",
			this.d().ToString(),
			"]"
		});
	}

	// Token: 0x060007B1 RID: 1969 RVA: 0x00020E98 File Offset: 0x0001F098
	internal Type a()
	{
		if (this.f != null)
		{
			return this.f;
		}
		cvq cvq = dr3.e();
		if (this.b())
		{
			Assembly assembly = null;
			if (!string.IsNullOrEmpty(this.f()))
			{
				try
				{
					assembly = Assembly.Load(this.f());
				}
				catch (Exception ex)
				{
					if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Warning, 100))
					{
						string a_ = string.Concat(new string[]
						{
							"Failed to load assembly for unit: ",
							this.y8(),
							". Full assembly name:",
							this.f(),
							". Exception: ",
							ex.ToString()
						});
						cvq.n7(LogSeverity.Warning, 100, a_);
					}
					return null;
				}
			}
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 100))
			{
				string a_2 = "Assembly for unit '" + this.y8() + "' retrieved successfully.";
				cvq.n7(LogSeverity.Information, 100, a_2);
			}
			Type result = null;
			try
			{
				result = assembly.GetType(this.c(), true);
			}
			catch (Exception ex2)
			{
				if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 100))
				{
					string a_3 = "Failed retrieving unit type: " + this.c() + ". Exception: " + ex2.ToString();
					cvq.n7(LogSeverity.Error, 100, a_3);
				}
				return null;
			}
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 100))
			{
				string a_4 = "Type retrieved successfully for unit: " + this.ToString();
				cvq.n7(LogSeverity.Information, 100, a_4);
			}
			this.f = result;
			return result;
		}
		return null;
	}

	// Token: 0x060007B2 RID: 1970 RVA: 0x00021074 File Offset: 0x0001F274
	internal bool b()
	{
		if (this.f != null)
		{
			return true;
		}
		cvq cvq = dr3.e();
		if (string.IsNullOrEmpty(this.c()))
		{
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 100))
			{
				string a_ = "Validation of UnitRef failed: " + this.ToString() + ". FullTypeName not specified.";
				cvq.n7(LogSeverity.Error, 100, a_);
			}
			return false;
		}
		if (string.IsNullOrEmpty(this.f()))
		{
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 100))
			{
				string a_2 = "Validation of UnitRef failed: " + this.ToString() + ". No assembly information specified.";
				cvq.n7(LogSeverity.Error, 100, a_2);
			}
			return false;
		}
		return true;
	}

	// Token: 0x04000572 RID: 1394
	private string a;

	// Token: 0x04000573 RID: 1395
	private string b;

	// Token: 0x04000574 RID: 1396
	private bool c = true;

	// Token: 0x04000575 RID: 1397
	private PropertyCollection d;

	// Token: 0x04000576 RID: 1398
	private string e;

	// Token: 0x04000577 RID: 1399
	[NonSerialized]
	private Type f;
}
