using System;
using System.Collections.Generic;
using System.Linq;
using Ouroboros.Core.Logging;

// Token: 0x02001331 RID: 4913
public static class dpo
{
	// Token: 0x06006F4E RID: 28494 RVA: 0x002EBB24 File Offset: 0x002E9D24
	static dpo()
	{
		dpo.a();
	}

	// Token: 0x06006F4F RID: 28495 RVA: 0x002EBB2C File Offset: 0x002E9D2C
	public static dqw b(av A_0)
	{
		czh.a(A_0, "proxy");
		dqw dqw = null;
		if (A_0.p() != null)
		{
			if (!string.IsNullOrEmpty(A_0.p().TechnicalName))
			{
				dpo.b.TryGetValue(A_0.p().TechnicalName, out dqw);
				if (dqw == null)
				{
					dux.b(LogSeverity.Error, rz.j, new object[]
					{
						A_0.p().TechnicalName
					});
				}
			}
			else
			{
				dux.b(LogSeverity.Error, rz.l, new object[0]);
			}
		}
		else
		{
			dux.b(LogSeverity.Error, rz.k, new object[0]);
		}
		return dqw;
	}

	// Token: 0x06006F50 RID: 28496 RVA: 0x002EBBD0 File Offset: 0x002E9DD0
	public static cbj a(av A_0)
	{
		czh.a(A_0, "proxy");
		cbj cbj = null;
		if (A_0.p() != null)
		{
			if (!string.IsNullOrEmpty(A_0.p().TechnicalName))
			{
				dpo.c.TryGetValue(A_0.p().TechnicalName, out cbj);
				if (cbj == null)
				{
					cbj = new bpd();
				}
			}
			else
			{
				dux.b(LogSeverity.Error, "Failed to retrieve aura execution plan. The capability's technical name was empty.", new object[0]);
			}
		}
		else
		{
			dux.b(LogSeverity.Error, "Failed to retrieve aura execution plan. The supplied proxy pointed to no capability.", new object[0]);
		}
		return cbj;
	}

	// Token: 0x06006F51 RID: 28497 RVA: 0x002EBC5C File Offset: 0x002E9E5C
	public static g5 b(string A_0)
	{
		g5 result = null;
		if (!string.IsNullOrEmpty(A_0))
		{
			Type type = null;
			dpo.d.TryGetValue(A_0, out type);
			if (type != null)
			{
				try
				{
					return (g5)Activator.CreateInstance(type);
				}
				catch (Exception a_)
				{
					dux.a(LogSeverity.Error, a_, "Failed to create an instance of status effect component action of type '{0}'.", new object[]
					{
						type.FullName
					});
					return result;
				}
			}
			dux.b(LogSeverity.Error, "Failed to retrieve action type for status effect component action '{0}'", new object[]
			{
				A_0
			});
		}
		else
		{
			dux.b(LogSeverity.Warning, "Attempted to retrieve status effect component action with an empty (or null) name.", new object[0]);
		}
		return result;
	}

	// Token: 0x06006F52 RID: 28498 RVA: 0x002EBD00 File Offset: 0x002E9F00
	public static bs8 a(string A_0)
	{
		bs8 result = null;
		if (!string.IsNullOrEmpty(A_0))
		{
			Type type = null;
			dpo.e.TryGetValue("HFX:" + A_0, out type);
			if (type != null)
			{
				try
				{
					return (bs8)Activator.CreateInstance(type);
				}
				catch (Exception a_)
				{
					dux.a(LogSeverity.Error, a_, "Failed to create an instance of hit effect action of type '{0}'.", new object[]
					{
						type.FullName
					});
					return result;
				}
			}
			dux.b(LogSeverity.Error, "Failed to retrieve action type for hit effect '{0}'", new object[]
			{
				A_0
			});
		}
		else
		{
			dux.b(LogSeverity.Warning, "Attempted to retrieve hit effect action with an empty (or null) name.", new object[0]);
		}
		return result;
	}

	// Token: 0x06006F53 RID: 28499 RVA: 0x002EBDB0 File Offset: 0x002E9FB0
	private static void a()
	{
		dpo.b = new Dictionary<string, dqw>();
		dpo.c = new Dictionary<string, cbj>();
		dpo.d = new Dictionary<string, Type>();
		dpo.e = new Dictionary<string, Type>();
		foreach (Type type in typeof(dpo).Assembly.GetTypes())
		{
			if (type.IsClass && !type.IsAbstract && type.GetConstructor(Type.EmptyTypes) != null)
			{
				if (typeof(dqw).IsAssignableFrom(type))
				{
					string key = dpo.a(type);
					try
					{
						dqw value = (dqw)Activator.CreateInstance(type);
						dpo.b[key] = value;
					}
					catch (Exception a_)
					{
						dux.a(LogSeverity.Error, a_, rz.b, new object[]
						{
							type.FullName
						});
					}
				}
				if (typeof(cbj).IsAssignableFrom(type))
				{
					string key2 = dpo.a(type);
					try
					{
						cbj value2 = (cbj)Activator.CreateInstance(type);
						dpo.c[key2] = value2;
					}
					catch (Exception a_2)
					{
						dux.a(LogSeverity.Error, a_2, "Failed to create an instace of aura execution plan of type '{0}'.", new object[]
						{
							type.FullName
						});
					}
				}
				if (typeof(g5).IsAssignableFrom(type))
				{
					dpo.d[dpo.b(type)] = type;
				}
				if (typeof(bs8).IsAssignableFrom(type))
				{
					dpo.e[dpo.b(type)] = type;
				}
			}
		}
	}

	// Token: 0x06006F54 RID: 28500 RVA: 0x002EBF68 File Offset: 0x002EA168
	private static string b(Type A_0)
	{
		bs6 bs = Enumerable.FirstOrDefault<object>(A_0.GetCustomAttributes(typeof(bs6), false)) as bs6;
		string result;
		if (bs != null && !string.IsNullOrWhiteSpace(bs.a()))
		{
			result = bs.a();
		}
		else
		{
			result = A_0.Name;
		}
		return result;
	}

	// Token: 0x06006F55 RID: 28501 RVA: 0x002EBFBC File Offset: 0x002EA1BC
	private static string a(Type A_0)
	{
		d1q d1q = Enumerable.FirstOrDefault<object>(A_0.GetCustomAttributes(typeof(d1q), false)) as d1q;
		string result;
		if (d1q != null && !string.IsNullOrWhiteSpace(d1q.a()))
		{
			result = d1q.a();
		}
		else if (A_0.Name.ToLowerInvariant().EndsWith("executionplan") && A_0.Name.Length > "executionplan".Length)
		{
			result = A_0.Name.Substring(0, A_0.Name.Length - "executionplan".Length);
		}
		else
		{
			result = A_0.Name;
		}
		return result;
	}

	// Token: 0x04002D86 RID: 11654
	private const string a = "executionplan";

	// Token: 0x04002D87 RID: 11655
	private static Dictionary<string, dqw> b;

	// Token: 0x04002D88 RID: 11656
	private static Dictionary<string, cbj> c;

	// Token: 0x04002D89 RID: 11657
	private static Dictionary<string, Type> d;

	// Token: 0x04002D8A RID: 11658
	private static Dictionary<string, Type> e;
}
