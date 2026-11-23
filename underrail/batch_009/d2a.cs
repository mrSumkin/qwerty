using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Ouroboros.Core.Logging;

// Token: 0x0200013C RID: 316
[eiz("MC")]
[Serializable]
public sealed class d2a : ISerializable
{
	// Token: 0x060007C2 RID: 1986 RVA: 0x000213B4 File Offset: 0x0001F5B4
	private d2a(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.a = A_0.GetString("MC:GRP");
			this.b = A_0.GetString("MC:GCFN");
			this.d = (a0j)A_0.GetValue("MC:LC", typeof(a0j));
			this.e = (dnl)A_0.GetValue("MC:MR", typeof(dnl));
			this.f = (ehj)A_0.GetValue("MC:LPR", typeof(ehj));
			this.g = (gw)A_0.GetValue("MC:RR", typeof(gw));
			this.h = A_0.GetDouble("MC:UR");
			this.i = (a5g)A_0.GetValue("MC:IPW", typeof(a5g));
			if (ell.b() >= 33)
			{
				this.c = A_0.GetString("MC:DP");
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(d2a))
			{
				this.a = A_0.GetString("_GameRootPath");
				this.b = A_0.GetString("_GameConfigurationFileName");
				this.d = (a0j)A_0.GetValue("_LoggerConfig", typeof(a0j));
				this.e = (dnl)A_0.GetValue("_ModuleReferences", typeof(dnl));
				this.f = (ehj)A_0.GetValue("_LogicProviderReferences", typeof(ehj));
				this.g = (gw)A_0.GetValue("_RendererReferences", typeof(gw));
				this.h = A_0.GetDouble("_UpdateRate");
				this.i = (a5g)A_0.GetValue("_InitProgramWorkflow", typeof(a5g));
				return;
			}
			this.a = A_0.GetString("MasterConfiguration+_GameRootPath");
			this.b = A_0.GetString("MasterConfiguration+_GameConfigurationFileName");
			this.d = (a0j)A_0.GetValue("MasterConfiguration+_LoggerConfig", typeof(a0j));
			this.e = (dnl)A_0.GetValue("MasterConfiguration+_ModuleReferences", typeof(dnl));
			this.f = (ehj)A_0.GetValue("MasterConfiguration+_LogicProviderReferences", typeof(ehj));
			this.g = (gw)A_0.GetValue("MasterConfiguration+_RendererReferences", typeof(gw));
			this.h = A_0.GetDouble("MasterConfiguration+_UpdateRate");
			this.i = (a5g)A_0.GetValue("MasterConfiguration+_InitProgramWorkflow", typeof(a5g));
		}
	}

	// Token: 0x060007C3 RID: 1987 RVA: 0x000216B0 File Offset: 0x0001F8B0
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("MC:GRP", this.a);
		info.AddValue("MC:GCFN", this.b);
		info.AddValue("MC:LC", this.d);
		info.AddValue("MC:MR", this.e);
		info.AddValue("MC:LPR", this.f);
		info.AddValue("MC:RR", this.g);
		info.AddValue("MC:UR", this.h);
		info.AddValue("MC:IPW", this.i);
	}

	// Token: 0x060007C4 RID: 1988 RVA: 0x00021748 File Offset: 0x0001F948
	public string i()
	{
		return this.a;
	}

	// Token: 0x060007C5 RID: 1989 RVA: 0x00021750 File Offset: 0x0001F950
	public void e(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060007C6 RID: 1990 RVA: 0x0002175C File Offset: 0x0001F95C
	public string h()
	{
		return this.c;
	}

	// Token: 0x060007C7 RID: 1991 RVA: 0x00021764 File Offset: 0x0001F964
	public void b(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060007C8 RID: 1992 RVA: 0x00021770 File Offset: 0x0001F970
	public a0j d()
	{
		return this.d;
	}

	// Token: 0x060007C9 RID: 1993 RVA: 0x00021778 File Offset: 0x0001F978
	public void a(a0j A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060007CA RID: 1994 RVA: 0x00021784 File Offset: 0x0001F984
	public string c()
	{
		return this.b;
	}

	// Token: 0x060007CB RID: 1995 RVA: 0x0002178C File Offset: 0x0001F98C
	public void d(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060007CC RID: 1996 RVA: 0x00021798 File Offset: 0x0001F998
	public dnl a()
	{
		return this.e;
	}

	// Token: 0x060007CD RID: 1997 RVA: 0x000217A0 File Offset: 0x0001F9A0
	public void a(dnl A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060007CE RID: 1998 RVA: 0x000217AC File Offset: 0x0001F9AC
	public ehj b()
	{
		return this.f;
	}

	// Token: 0x060007CF RID: 1999 RVA: 0x000217B4 File Offset: 0x0001F9B4
	public void a(ehj A_0)
	{
		this.f = A_0;
	}

	// Token: 0x060007D0 RID: 2000 RVA: 0x000217C0 File Offset: 0x0001F9C0
	public gw g()
	{
		return this.g;
	}

	// Token: 0x060007D1 RID: 2001 RVA: 0x000217C8 File Offset: 0x0001F9C8
	public void a(gw A_0)
	{
		this.g = A_0;
	}

	// Token: 0x060007D2 RID: 2002 RVA: 0x000217D4 File Offset: 0x0001F9D4
	public double f()
	{
		return this.h;
	}

	// Token: 0x060007D3 RID: 2003 RVA: 0x000217DC File Offset: 0x0001F9DC
	public void a(double A_0)
	{
		this.h = A_0;
	}

	// Token: 0x060007D4 RID: 2004 RVA: 0x000217E8 File Offset: 0x0001F9E8
	public a5g e()
	{
		return this.i;
	}

	// Token: 0x060007D5 RID: 2005 RVA: 0x000217F0 File Offset: 0x0001F9F0
	public void a(a5g A_0)
	{
		this.i = A_0;
	}

	// Token: 0x060007D6 RID: 2006 RVA: 0x000217FC File Offset: 0x0001F9FC
	public d2a()
	{
	}

	// Token: 0x060007D7 RID: 2007 RVA: 0x00021834 File Offset: 0x0001FA34
	internal void c(string A_0)
	{
		cvq cvq = dr3.e();
		FileStream fileStream = null;
		try
		{
			if (File.Exists(A_0))
			{
				File.Delete(A_0);
			}
			fileStream = File.Create(A_0);
			new XmlSerializer(typeof(d2a)).Serialize(fileStream, this);
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 100))
			{
				string a_ = "Master configuration saved to: " + A_0;
				cvq.n7(LogSeverity.Information, 100, a_);
			}
		}
		catch (Exception ex)
		{
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 100))
			{
				string a_2 = "Error occurred while saving master configuration. Exception: " + ex.ToString();
				cvq.n7(LogSeverity.Error, 100, a_2);
			}
		}
		finally
		{
			if (fileStream != null)
			{
				fileStream.Flush();
				fileStream.Dispose();
			}
		}
	}

	// Token: 0x060007D8 RID: 2008 RVA: 0x00021924 File Offset: 0x0001FB24
	internal static d2a a(string A_0)
	{
		cvq cvq = dr3.e();
		FileStream fileStream = null;
		d2a result;
		try
		{
			fileStream = File.Open(A_0, FileMode.Open, FileAccess.Read);
			d2a d2a = new XmlSerializer(typeof(d2a)).Deserialize(fileStream) as d2a;
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 100))
			{
				string a_ = "Master configuration loaded successfully from: " + A_0;
				cvq.n7(LogSeverity.Information, 100, a_);
			}
			result = d2a;
		}
		catch (Exception ex)
		{
			string text = "Error occurred while loading master configuration.";
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.CriticalError, 100))
			{
				cvq.n7(LogSeverity.CriticalError, 100, text + " Exception: " + ex.ToString());
			}
			throw new Exception(text, ex);
		}
		finally
		{
			if (fileStream != null)
			{
				fileStream.Close();
			}
		}
		return result;
	}

	// Token: 0x0400057B RID: 1403
	private string a;

	// Token: 0x0400057C RID: 1404
	private string b;

	// Token: 0x0400057D RID: 1405
	private string c;

	// Token: 0x0400057E RID: 1406
	private a0j d = new a0j();

	// Token: 0x0400057F RID: 1407
	private dnl e = new dnl();

	// Token: 0x04000580 RID: 1408
	private ehj f = new ehj();

	// Token: 0x04000581 RID: 1409
	private gw g = new gw();

	// Token: 0x04000582 RID: 1410
	private double h;

	// Token: 0x04000583 RID: 1411
	private a5g i;
}
