using System;
using System.Collections.Generic;
using System.Reflection;

// Token: 0x02001021 RID: 4129
public static class ea5
{
	// Token: 0x06005537 RID: 21815 RVA: 0x0025A970 File Offset: 0x00258B70
	public static void c()
	{
		if (!ea5.b)
		{
			bpo.RegisterService<bj9>(new ea5.a());
			ea5.a();
			ea5.b = true;
		}
	}

	// Token: 0x06005538 RID: 21816 RVA: 0x0025A994 File Offset: 0x00258B94
	public static af7 b(string A_0)
	{
		ea5.c();
		if (A_0 != null)
		{
			af7 result;
			ea5.a.TryGetValue(A_0, out result);
			return result;
		}
		return null;
	}

	// Token: 0x06005539 RID: 21817 RVA: 0x0025A9C0 File Offset: 0x00258BC0
	public static Dictionary<string, af7> b()
	{
		ea5.c();
		return ea5.a;
	}

	// Token: 0x0600553A RID: 21818 RVA: 0x0025A9CC File Offset: 0x00258BCC
	public static cxz a(string A_0)
	{
		if (ea5.b(A_0) != null)
		{
			return new cxz(A_0);
		}
		return null;
	}

	// Token: 0x0600553B RID: 21819 RVA: 0x0025A9E4 File Offset: 0x00258BE4
	public static void a(string A_0, c5x A_1, c5x A_2, Dictionary<string, object> A_3)
	{
		ea5.c();
		if (!string.IsNullOrEmpty(A_0))
		{
			af7 af = ea5.b(A_0);
			if (af != null)
			{
				af(A_1, A_2, A_3);
			}
		}
	}

	// Token: 0x0600553C RID: 21820 RVA: 0x0025AA18 File Offset: 0x00258C18
	public static void a(ix A_0, string A_1, c5x A_2, c5x A_3, Dictionary<string, object> A_4)
	{
		if (A_0 != null && !string.IsNullOrEmpty(A_1))
		{
			cxz cxz = ea5.a(A_1);
			if (cxz != null)
			{
				A_0.g9(new a4s(cxz, (A_2 != null) ? new ar7(A_2) : null, (A_3 != null) ? new ar7(A_3) : null, A_4), atp.a);
			}
		}
	}

	// Token: 0x0600553D RID: 21821 RVA: 0x0025AA78 File Offset: 0x00258C78
	private static void a()
	{
		foreach (Type type in bpo.GetServiceOrThrow<ei2>().avx())
		{
			if (type.IsClass && !type.IsAbstract && boo.GetSingletonCustomAttribute<euj>(type) != null && type.GetConstructor(Type.EmptyTypes) != null)
			{
				try
				{
					object obj = Activator.CreateInstance(type);
					if (obj != null)
					{
						foreach (MethodInfo methodInfo in type.GetMethods(BindingFlags.Instance | BindingFlags.Public))
						{
							object[] customAttributes = methodInfo.GetCustomAttributes(typeof(ayh), true);
							if (customAttributes != null && customAttributes.Length != 0)
							{
								try
								{
									af7 af = Delegate.CreateDelegate(typeof(af7), obj, methodInfo) as af7;
									if (af != null)
									{
										object[] array = customAttributes;
										for (int j = 0; j < array.Length; j++)
										{
											ayh ayh = array[j] as ayh;
											if (ayh != null && !string.IsNullOrEmpty(ayh.a))
											{
												ea5.a[ayh.a] = af;
											}
										}
									}
								}
								catch (Exception)
								{
								}
							}
						}
					}
				}
				catch
				{
				}
			}
		}
	}

	// Token: 0x040022BC RID: 8892
	private static Dictionary<string, af7> a = new Dictionary<string, af7>();

	// Token: 0x040022BD RID: 8893
	private static bool b;

	// Token: 0x02001022 RID: 4130
	private sealed class a : bj9
	{
		// Token: 0x0600553E RID: 21822 RVA: 0x0025AC28 File Offset: 0x00258E28
		public void ae4(string A_0, object A_1, object A_2, Dictionary<string, object> A_3)
		{
			ea5.a(A_0, A_1 as c5x, A_2 as c5x, A_3);
		}
	}
}
