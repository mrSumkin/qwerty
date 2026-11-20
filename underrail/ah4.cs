using System;
using System.Collections.Generic;
using System.Diagnostics;
using Ouroboros.Common.Data;
using Ouroboros.Core.Logging;

// Token: 0x0200012E RID: 302
[DebuggerDisplay("Count = {Count}")]
public sealed class ah4
{
	// Token: 0x0600073A RID: 1850 RVA: 0x0001DDB0 File Offset: 0x0001BFB0
	public int f()
	{
		return this.a.Count;
	}

	// Token: 0x0600073B RID: 1851 RVA: 0x0001DDC0 File Offset: 0x0001BFC0
	internal void a(dnl A_0, ehj A_1, gw A_2)
	{
		this.a(A_0);
		this.h();
		this.c();
		this.e();
		this.a(A_1);
		this.a(A_2);
	}

	// Token: 0x0600073C RID: 1852 RVA: 0x0001DDF4 File Offset: 0x0001BFF4
	internal void i()
	{
		this.b();
		this.g();
		this.d();
	}

	// Token: 0x0600073D RID: 1853 RVA: 0x0001DE08 File Offset: 0x0001C008
	internal void a(dnl A_0)
	{
		cvq cvq = dr3.e();
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 108))
		{
			string a_ = "[Modularity Manager] - Loading modules...";
			cvq.n7(LogSeverity.Information, 108, a_);
		}
		foreach (a5g a5g in A_0)
		{
			if (a5g != null)
			{
				Type type = a5g.a();
				if (type == null)
				{
					ah4.a(a5g);
				}
				object obj = null;
				try
				{
					obj = Activator.CreateInstance(type, true);
				}
				catch (Exception ex)
				{
					if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 108))
					{
						string a_2 = "[Modularity Manager] - Failed to instance module of type: " + type.AssemblyQualifiedName + ". Exception" + ex.ToString();
						cvq.n7(LogSeverity.Error, 108, a_2);
					}
					if (a5g.d())
					{
						ah4.a(a5g);
					}
					continue;
				}
				eu eu = obj as eu;
				if (eu == null)
				{
					if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 108))
					{
						string a_3 = "[Modularity Manager] - Failed to load module. Type '" + type.AssemblyQualifiedName + "' does not implement IModule interface.";
						cvq.n7(LogSeverity.Error, 108, a_3);
					}
					if (a5g.d())
					{
						ah4.a(a5g);
					}
				}
				if (ah4.a(eu, a5g))
				{
					eu.au9(a5g.e() ?? new PropertyCollection());
					this.a.Add(eu, a5g.d());
					if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 108))
					{
						string a_4 = "[Modularity Manager] - Module loaded successfully: " + eu.ToString();
						cvq.n7(LogSeverity.Information, 108, a_4);
					}
				}
				else if (a5g.d())
				{
					ah4.a(a5g);
				}
			}
		}
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 108))
		{
			string a_5 = "[Modularity Manager] - Module loading complete.";
			cvq.n7(LogSeverity.Information, 108, a_5);
		}
	}

	// Token: 0x0600073E RID: 1854 RVA: 0x0001E064 File Offset: 0x0001C264
	internal void h()
	{
		cvq cvq = dr3.e();
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 108))
		{
			string a_ = "[Modularity Manager] - Early initialization started...";
			cvq.n7(LogSeverity.Information, 108, a_);
		}
		foreach (eu eu in this.a.Keys)
		{
			try
			{
				eu.qf();
				if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 108))
				{
					string a_2 = "[Modularity Manager] - Early initialization successful for module: [" + eu.qe().ToString() + "] " + eu.y8();
					cvq.n7(LogSeverity.Information, 108, a_2);
				}
			}
			catch (Exception ex)
			{
				if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 108))
				{
					string a_3 = string.Concat(new string[]
					{
						"[Modularity Manager] - Early initialization failed for module: [",
						eu.qe().ToString(),
						"] ",
						eu.y8(),
						". Exception: ",
						ex.ToString()
					});
					cvq.n7(LogSeverity.Error, 108, a_3);
				}
				return;
			}
		}
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 108))
		{
			string a_4 = "[Modularity Manager] - Early initialization complete.";
			cvq.n7(LogSeverity.Information, 108, a_4);
		}
	}

	// Token: 0x0600073F RID: 1855 RVA: 0x0001E22C File Offset: 0x0001C42C
	internal void c()
	{
		cvq cvq = dr3.e();
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 108))
		{
			string a_ = "[Modularity Manager] - Late initialization started...";
			cvq.n7(LogSeverity.Information, 108, a_);
		}
		foreach (eu eu in this.a.Keys)
		{
			try
			{
				eu.xd();
				if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 108))
				{
					string a_2 = "[Modularity Manager] - Late initialization successful for module: [" + eu.qe().ToString() + "] " + eu.y8();
					cvq.n7(LogSeverity.Information, 108, a_2);
				}
			}
			catch (Exception ex)
			{
				if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 108))
				{
					string a_3 = string.Concat(new string[]
					{
						"[Modularity Manager] - Late intialization failed for module: [",
						eu.qe().ToString(),
						"] ",
						eu.y8(),
						". Exception: ",
						ex.ToString()
					});
					cvq.n7(LogSeverity.Error, 108, a_3);
				}
			}
		}
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 108))
		{
			string a_4 = "[Modularity Manager] - Late initialization complete.";
			cvq.n7(LogSeverity.Information, 108, a_4);
		}
	}

	// Token: 0x06000740 RID: 1856 RVA: 0x0001E3F4 File Offset: 0x0001C5F4
	internal void e()
	{
		foreach (eu eu in this.a.Keys)
		{
			if (eu.qi() != null)
			{
				foreach (z6 item in eu.qi())
				{
					this.b.Add(item);
				}
			}
			if (eu.qh() != null)
			{
				foreach (ajx item2 in eu.qh())
				{
					this.c.Add(item2);
				}
			}
		}
	}

	// Token: 0x06000741 RID: 1857 RVA: 0x0001E500 File Offset: 0x0001C700
	internal void a()
	{
		cvq cvq = dr3.e();
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 108))
		{
			string a_ = "[Modularity Manager] - Validation module layout...";
			cvq.n7(LogSeverity.Information, 108, a_);
		}
		List<eu> list = new List<eu>();
		foreach (eu eu in this.a.Keys)
		{
			object[] customAttributes = eu.GetType().GetCustomAttributes(typeof(dks), false);
			if (customAttributes != null)
			{
				object[] array = customAttributes;
				for (int i = 0; i < array.Length; i++)
				{
					dks dks = array[i] as dks;
					if (dks != null && !this.a(dks))
					{
						if (dks.c())
						{
							list.Add(eu);
							if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 108))
							{
								string a_2 = string.Concat(new string[]
								{
									"[Modularity Manager] - Module ",
									eu.ToString(),
									" cannot be initialized. Dependant module not loaded: ",
									dks.ToString(),
									". Module will be removed."
								});
								cvq.n7(LogSeverity.Error, 108, a_2);
								break;
							}
							break;
						}
						else if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Warning, 108))
						{
							string a_3 = "[Modularity Manager] - Non-critical dependency (" + dks.ToString() + ")not found for module: " + eu.ToString();
							cvq.n7(LogSeverity.Warning, 108, a_3);
						}
					}
				}
			}
		}
		foreach (eu eu2 in list)
		{
			if (this.a[eu2])
			{
				ah4.a(eu2);
			}
			this.a.Remove(eu2);
		}
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 108))
		{
			string a_4 = "[Modularity Manager] - Module layout validation complete.";
			cvq.n7(LogSeverity.Information, 108, a_4);
		}
	}

	// Token: 0x06000742 RID: 1858 RVA: 0x0001E768 File Offset: 0x0001C968
	internal void a(ehj A_0)
	{
		cvq cvq = dr3.e();
		a1y a1y = dr3.c();
		if (a1y == null)
		{
			string text = "Logic Manager service not found.";
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.CriticalError, 108))
			{
				string a_ = "[Modularity Manager] - " + text;
				cvq.n7(LogSeverity.CriticalError, 108, a_);
			}
			throw new Exception(text);
		}
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 108))
		{
			string a_2 = "[Modularity Manager] - Inserting logic providers...";
			cvq.n7(LogSeverity.Information, 108, a_2);
		}
		foreach (dbc dbc in A_0)
		{
			if (ah4.a(dbc))
			{
				z6 z = this.b(dbc);
				if (z == null)
				{
					if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 108))
					{
						string a_3 = "[Modularity Manager] - Logic provider not found: " + dbc.ToString();
						cvq.n7(LogSeverity.Error, 108, a_3);
					}
					if (!dbc.a())
					{
						continue;
					}
					ah4.c(dbc);
				}
				a1y.xf(z);
			}
			else if (dbc.a())
			{
				ah4.c(dbc);
			}
		}
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 108))
		{
			string a_4 = "[Modularity Manager] - Insertion of logic providers complete.";
			cvq.n7(LogSeverity.Information, 108, a_4);
		}
	}

	// Token: 0x06000743 RID: 1859 RVA: 0x0001E900 File Offset: 0x0001CB00
	internal void g()
	{
		cvq cvq = dr3.e();
		a1y a1y = dr3.c();
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 108))
		{
			string a_ = "[Modularity Manager] - Removing logic providers...";
			cvq.n7(LogSeverity.Information, 108, a_);
		}
		if (a1y == null)
		{
			string text = "Logic Manager service not found.";
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.CriticalError, 108))
			{
				string a_2 = "[Modularity Manager] - " + text;
				cvq.n7(LogSeverity.CriticalError, 108, a_2);
			}
			throw new Exception(text);
		}
		foreach (z6 a_3 in this.b)
		{
			a1y.xg(a_3);
		}
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 108))
		{
			string a_4 = "[Modularity Manager] - Removal of logic providers complete.";
			cvq.n7(LogSeverity.Information, 108, a_4);
		}
	}

	// Token: 0x06000744 RID: 1860 RVA: 0x0001EA14 File Offset: 0x0001CC14
	internal void a(gw A_0)
	{
		cvq cvq = dr3.e();
		s6 s = dr3.b();
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 108))
		{
			string a_ = "[Modularity Manager] - Inserting renderers...";
			cvq.n7(LogSeverity.Information, 108, a_);
		}
		if (s == null)
		{
			string text = "Rendering Manager service not found.";
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.CriticalError, 108))
			{
				string a_2 = "[Modularity Manager] - " + text;
				cvq.n7(LogSeverity.CriticalError, 108, a_2);
			}
			throw new Exception(text);
		}
		foreach (eaa eaa in A_0)
		{
			if (ah4.a(eaa))
			{
				ajx ajx = this.b(eaa);
				if (ajx == null)
				{
					if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 108))
					{
						string a_3 = "[Modularity Manager] - Renderer not found: " + eaa.ToString();
						cvq.n7(LogSeverity.Error, 108, a_3);
					}
					if (!eaa.a())
					{
						continue;
					}
					ah4.c(eaa);
				}
				s.m6(ajx);
			}
			else if (eaa.a())
			{
				ah4.c(eaa);
			}
		}
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 108))
		{
			string a_4 = "[Modularity Manager] - Insertion of renderers complete.";
			cvq.n7(LogSeverity.Information, 108, a_4);
		}
	}

	// Token: 0x06000745 RID: 1861 RVA: 0x0001EBAC File Offset: 0x0001CDAC
	internal void b()
	{
		cvq cvq = dr3.e();
		s6 s = dr3.b();
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 108))
		{
			string a_ = "[Modularity Manager] - Removing renderers...";
			cvq.n7(LogSeverity.Information, 108, a_);
		}
		if (s == null)
		{
			string text = "Rendering Manager service not found.";
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.CriticalError, 108))
			{
				string a_2 = "[Modularity Manager] - " + text;
				cvq.n7(LogSeverity.CriticalError, 108, a_2);
			}
			throw new Exception(text);
		}
		foreach (ajx a_3 in this.c)
		{
			s.m7(a_3);
		}
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 108))
		{
			string a_4 = "[Modularity Manager] - Removal of renderers complete.";
			cvq.n7(LogSeverity.Information, 108, a_4);
		}
	}

	// Token: 0x06000746 RID: 1862 RVA: 0x0001ECC0 File Offset: 0x0001CEC0
	internal void d()
	{
		cvq cvq = dr3.e();
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 108))
		{
			string a_ = "[Modularity Manager] - Unloading modules...";
			cvq.n7(LogSeverity.Information, 108, a_);
		}
		foreach (eu eu in this.a.Keys)
		{
			try
			{
				eu.qg();
				if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 108))
				{
					string a_2 = "[Modularity Manager] - Module unloaded successfully: " + eu.ToString();
					cvq.n7(LogSeverity.Information, 108, a_2);
				}
			}
			catch (Exception ex)
			{
				if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 108))
				{
					string a_3 = "[Modularity Manager] - Failed to unload module: " + eu.ToString() + ". Exception: " + ex.ToString();
					cvq.n7(LogSeverity.Error, 108, a_3);
				}
			}
		}
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 108))
		{
			string a_4 = "[Modularity Manager] - Modules unloaded.";
			cvq.n7(LogSeverity.Information, 108, a_4);
		}
	}

	// Token: 0x06000747 RID: 1863 RVA: 0x0001EE24 File Offset: 0x0001D024
	private static void a(a5g A_0)
	{
		cvq cvq = dr3.e();
		string text = string.Format("[Modularity Manager] - Critical module failed to load/initialize: {0}.", A_0.ToString());
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.CriticalError, 108))
		{
			cvq.n7(LogSeverity.CriticalError, 108, text);
		}
		throw new Exception(text);
	}

	// Token: 0x06000748 RID: 1864 RVA: 0x0001EE78 File Offset: 0x0001D078
	private static void a(eu A_0)
	{
		cvq cvq = dr3.e();
		string text = "[Modularity Manager] - Critical module failed to load/initialize: " + A_0.ToString();
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.CriticalError, 108))
		{
			cvq.n7(LogSeverity.CriticalError, 108, text);
		}
		throw new Exception(text);
	}

	// Token: 0x06000749 RID: 1865 RVA: 0x0001EECC File Offset: 0x0001D0CC
	private static void c(dbc A_0)
	{
		cvq cvq = dr3.e();
		string text = "[Modularity Manager] - Critical logic provider failed to load/initialize: " + A_0.ToString();
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.CriticalError, 108))
		{
			cvq.n7(LogSeverity.CriticalError, 108, text);
		}
		throw new Exception(text);
	}

	// Token: 0x0600074A RID: 1866 RVA: 0x0001EF20 File Offset: 0x0001D120
	private static void c(eaa A_0)
	{
		cvq cvq = dr3.e();
		string text = "[Modularity Manager] - Critical renderer failed to load/initialize: " + A_0.ToString();
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.CriticalError, 108))
		{
			cvq.n7(LogSeverity.CriticalError, 108, text);
		}
		throw new Exception(text);
	}

	// Token: 0x0600074B RID: 1867 RVA: 0x0001EF74 File Offset: 0x0001D174
	private bool a(dks A_0)
	{
		foreach (eu eu in this.a.Keys)
		{
			bool flag = true;
			if (A_0.a() != Guid.Empty && A_0.a() != eu.qe())
			{
				flag = false;
			}
			if (!string.IsNullOrEmpty(A_0.b()) && A_0.b() != eu.y8())
			{
				flag = false;
			}
			if (flag)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600074C RID: 1868 RVA: 0x0001F034 File Offset: 0x0001D234
	private z6 b(dbc A_0)
	{
		foreach (z6 z in this.b)
		{
			if (z.qe() == A_0.b())
			{
				return z;
			}
			if (z.y8() == A_0.c())
			{
				return z;
			}
		}
		return null;
	}

	// Token: 0x0600074D RID: 1869 RVA: 0x0001F0C4 File Offset: 0x0001D2C4
	private ajx b(eaa A_0)
	{
		foreach (ajx ajx in this.c)
		{
			if (ajx.qe() == A_0.b())
			{
				return ajx;
			}
			if (ajx.y8() == A_0.c())
			{
				return ajx;
			}
		}
		return null;
	}

	// Token: 0x0600074E RID: 1870 RVA: 0x0001F154 File Offset: 0x0001D354
	private static bool a(eu A_0, a5g A_1)
	{
		cvq cvq = dr3.e();
		if (string.IsNullOrEmpty(A_0.y8()))
		{
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 108))
			{
				string a_ = "[Modularity Manager] - Failed to process module: " + A_1.c() + ". + Module must specify a name.";
				cvq.n7(LogSeverity.Error, 108, a_);
			}
			return false;
		}
		if (A_0.qe() == Guid.Empty)
		{
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 108))
			{
				string a_2 = "[Modularity Manager] - Failed to process module: " + A_1.c() + ". + Module must specify a valid id";
				cvq.n7(LogSeverity.Error, 108, a_2);
			}
			return false;
		}
		return true;
	}

	// Token: 0x0600074F RID: 1871 RVA: 0x0001F210 File Offset: 0x0001D410
	private static bool a(dbc A_0)
	{
		cvq cvq = dr3.e();
		if (A_0.d())
		{
			return true;
		}
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 108))
		{
			string a_ = "[Modularity Manager] - Logic provider reference is not valid. You must specify at least one of the following: Id, Name.";
			cvq.n7(LogSeverity.Error, 108, a_);
		}
		return false;
	}

	// Token: 0x06000750 RID: 1872 RVA: 0x0001F260 File Offset: 0x0001D460
	private static bool a(eaa A_0)
	{
		cvq cvq = dr3.e();
		if (A_0.d())
		{
			return true;
		}
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 108))
		{
			string a_ = "[Modularity Manager] - Renderer reference is not valid. You must specify at least one of the following: Id, Name.";
			cvq.n7(LogSeverity.Error, 108, a_);
		}
		return false;
	}

	// Token: 0x04000555 RID: 1365
	private Dictionary<eu, bool> a = new Dictionary<eu, bool>();

	// Token: 0x04000556 RID: 1366
	private List<z6> b = new List<z6>();

	// Token: 0x04000557 RID: 1367
	private List<ajx> c = new List<ajx>();
}
