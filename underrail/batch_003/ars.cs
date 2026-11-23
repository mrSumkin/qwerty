using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Ouroboros.Core.Logging;

// Token: 0x02000565 RID: 1381
public static class ars
{
	// Token: 0x060023CC RID: 9164 RVA: 0x000C6474 File Offset: 0x000C4674
	public static List<mg> e()
	{
		return ars.b;
	}

	// Token: 0x060023CD RID: 9165 RVA: 0x000C647C File Offset: 0x000C467C
	public static List<dqb> d()
	{
		return ars.c;
	}

	// Token: 0x060023CE RID: 9166 RVA: 0x000C6484 File Offset: 0x000C4684
	static ars()
	{
		ars.c();
		ars.b();
		ars.a();
	}

	// Token: 0x060023CF RID: 9167 RVA: 0x000C6498 File Offset: 0x000C4698
	public static List<bwf> a(string A_0)
	{
		if (!string.IsNullOrEmpty(A_0))
		{
			List<bwf> result;
			ars.a.TryGetValue(A_0.ToLowerInvariant(), out result);
			return result;
		}
		return null;
	}

	// Token: 0x060023D0 RID: 9168 RVA: 0x000C64C8 File Offset: 0x000C46C8
	private static void c()
	{
		ars.a = new Dictionary<string, List<bwf>>();
		foreach (Type type in bpo.GetServiceOrThrow<ei2>().av2(new Func<Type, bool>(ars.a.a.c)))
		{
			try
			{
				if (type.IsClass && !type.IsAbstract)
				{
					if (type.GetConstructor(Type.EmptyTypes) != null)
					{
						fg a_ = (fg)Activator.CreateInstance(type);
						bmq bmq = Enumerable.FirstOrDefault<object>(type.GetCustomAttributes(typeof(bmq), false)) as bmq;
						if (bmq != null)
						{
							Version a_2;
							if (Version.TryParse(bmq.a(), out a_2))
							{
								if (!string.IsNullOrEmpty(bmq.d()))
								{
									string[] array = bmq.d().Split(new char[]
									{
										','
									}, StringSplitOptions.RemoveEmptyEntries);
									for (int i = 0; i < array.Length; i++)
									{
										string key = array[i].ToLowerInvariant().Trim();
										bwf item = new bwf(bmq.c(), a_2, a_, bmq.b());
										List<bwf> list;
										ars.a.TryGetValue(key, out list);
										if (list == null)
										{
											list = new List<bwf>();
											ars.a[key] = list;
										}
										list.Add(item);
									}
								}
								else
								{
									dux.b(LogSeverity.Error, "PatchLibrary: Failed to instantiate locale patch '{0}'. Target locale is null or empty.", new object[]
									{
										type.AssemblyQualifiedName
									});
								}
							}
							else
							{
								dux.b(LogSeverity.Error, "PatchLibrary: Failed to instantiate locale patch '{0}'. Unable to parse target version.", new object[]
								{
									type.AssemblyQualifiedName
								});
							}
						}
						else
						{
							dux.b(LogSeverity.Error, "PatchLibrary: Failed to instantiate locale patch '{0}'. Attribute not found.", new object[]
							{
								type.AssemblyQualifiedName
							});
						}
					}
					else
					{
						dux.b(LogSeverity.Error, "PatchLibrary: Failed to instantiate locale patch '{0}'. Default constructor not found.", new object[]
						{
							type.AssemblyQualifiedName
						});
					}
				}
			}
			catch (Exception a_3)
			{
				dux.a(LogSeverity.Error, a_3, "PatchLibrary: Failed to instantiate locale patch.", new object[0]);
			}
		}
		foreach (KeyValuePair<string, List<bwf>> keyValuePair in Enumerable.ToList<KeyValuePair<string, List<bwf>>>(ars.a))
		{
			ars.a[keyValuePair.Key] = Enumerable.ToList<bwf>(Enumerable.OrderBy<bwf, Version>(keyValuePair.Value, new Func<bwf, Version>(ars.a.a.a)));
		}
	}

	// Token: 0x060023D1 RID: 9169 RVA: 0x000C67B0 File Offset: 0x000C49B0
	private static void b()
	{
		ars.b = new List<mg>();
		foreach (Type type in bpo.GetServiceOrThrow<ei2>().av2(new Func<Type, bool>(ars.a.a.b)))
		{
			try
			{
				if (type.IsClass && !type.IsAbstract)
				{
					if (type.GetConstructor(Type.EmptyTypes) != null)
					{
						cwo cwo = (cwo)Activator.CreateInstance(type);
						s3 s = Enumerable.FirstOrDefault<object>(type.GetCustomAttributes(typeof(s3), false)) as s3;
						if (s != null)
						{
							Version a_;
							if (Version.TryParse(s.a(), out a_))
							{
								mx a_2 = cwo as mx;
								mg item = new mg(s.b(), a_, cwo, a_2);
								ars.b.Add(item);
							}
							else
							{
								dux.b(LogSeverity.Error, "PatchLibrary: Failed to instantiate global patch '{0}'. Unable to parse target version.", new object[]
								{
									type.AssemblyQualifiedName
								});
							}
						}
						else
						{
							dux.b(LogSeverity.Error, "PatchLibrary: Failed to instantiate global patch '{0}'. Attribute not found.", new object[]
							{
								type.AssemblyQualifiedName
							});
						}
					}
					else
					{
						dux.b(LogSeverity.Error, "PatchLibrary: Failed to instantiate global patch '{0}'. Default constructor not found.", new object[]
						{
							type.AssemblyQualifiedName
						});
					}
				}
			}
			catch (Exception a_3)
			{
				dux.a(LogSeverity.Error, a_3, "PatchLibrary: Failed to instantiate global patch.", new object[0]);
			}
		}
		ars.b = Enumerable.ToList<mg>(Enumerable.OrderBy<mg, Version>(ars.b, new Func<mg, Version>(ars.a.a.a)));
	}

	// Token: 0x060023D2 RID: 9170 RVA: 0x000C69A0 File Offset: 0x000C4BA0
	private static void a()
	{
		ars.c = new List<dqb>();
		foreach (Type type in bpo.GetServiceOrThrow<ei2>().av2(new Func<Type, bool>(ars.a.a.a)))
		{
			try
			{
				if (type.IsClass && !type.IsAbstract)
				{
					if (type.GetConstructor(Type.EmptyTypes) != null)
					{
						dnv a_ = (dnv)Activator.CreateInstance(type);
						dp2 dp = Enumerable.FirstOrDefault<object>(type.GetCustomAttributes(typeof(dp2), false)) as dp2;
						if (dp != null)
						{
							Version a_2;
							if (Version.TryParse(dp.a(), out a_2))
							{
								dqb item = new dqb(dp.b(), a_2, a_);
								ars.c.Add(item);
							}
							else
							{
								dux.b(LogSeverity.Error, "PatchLibrary: Failed to instantiate item patch '{0}'. Unable to parse target version.", new object[]
								{
									type.AssemblyQualifiedName
								});
							}
						}
						else
						{
							dux.b(LogSeverity.Error, "PatchLibrary: Failed to instantiate item patch '{0}'. Attribute not found.", new object[]
							{
								type.AssemblyQualifiedName
							});
						}
					}
					else
					{
						dux.b(LogSeverity.Error, "PatchLibrary: Failed to instantiate item patch '{0}'. Default constructor not found.", new object[]
						{
							type.AssemblyQualifiedName
						});
					}
				}
			}
			catch (Exception a_3)
			{
				dux.a(LogSeverity.Error, a_3, "PatchLibrary: Failed to instantiate item patch.", new object[0]);
			}
		}
		ars.c = Enumerable.ToList<dqb>(Enumerable.OrderBy<dqb, Version>(ars.c, new Func<dqb, Version>(ars.a.a.a)));
	}

	// Token: 0x040014C0 RID: 5312
	private static Dictionary<string, List<bwf>> a;

	// Token: 0x040014C1 RID: 5313
	private static List<mg> b;

	// Token: 0x040014C2 RID: 5314
	private static List<dqb> c;

	// Token: 0x02000566 RID: 1382
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x060023D5 RID: 9173 RVA: 0x000C6B98 File Offset: 0x000C4D98
		internal bool c(Type A_0)
		{
			return typeof(fg).IsAssignableFrom(A_0);
		}

		// Token: 0x060023D6 RID: 9174 RVA: 0x000C6BAC File Offset: 0x000C4DAC
		internal Version a(bwf A_0)
		{
			return A_0.TargetVersion;
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x000C6BB4 File Offset: 0x000C4DB4
		internal bool b(Type A_0)
		{
			return typeof(cwo).IsAssignableFrom(A_0);
		}

		// Token: 0x060023D8 RID: 9176 RVA: 0x000C6BC8 File Offset: 0x000C4DC8
		internal Version a(mg A_0)
		{
			return A_0.b;
		}

		// Token: 0x060023D9 RID: 9177 RVA: 0x000C6BD0 File Offset: 0x000C4DD0
		internal bool a(Type A_0)
		{
			return typeof(dnv).IsAssignableFrom(A_0);
		}

		// Token: 0x060023DA RID: 9178 RVA: 0x000C6BE4 File Offset: 0x000C4DE4
		internal Version a(dqb A_0)
		{
			return A_0.TargetVersion;
		}

		// Token: 0x040014C3 RID: 5315
		public static readonly ars.a a = new ars.a();

		// Token: 0x040014C4 RID: 5316
		public static Func<Type, bool> b;

		// Token: 0x040014C5 RID: 5317
		public static Func<bwf, Version> c;

		// Token: 0x040014C6 RID: 5318
		public static Func<Type, bool> d;

		// Token: 0x040014C7 RID: 5319
		public static Func<mg, Version> e;

		// Token: 0x040014C8 RID: 5320
		public static Func<Type, bool> f;

		// Token: 0x040014C9 RID: 5321
		public static Func<dqb, Version> g;
	}
}
