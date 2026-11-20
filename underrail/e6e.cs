using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework;
using Ouroboros.Core.Logging;

// Token: 0x020000A8 RID: 168
public abstract class e6e : ei2
{
	// Token: 0x060003CB RID: 971 RVA: 0x00011E78 File Offset: 0x00010078
	public List<Type> avx()
	{
		return this.m;
	}

	// Token: 0x060003CC RID: 972 RVA: 0x00011E80 File Offset: 0x00010080
	public bool c()
	{
		return this.n;
	}

	// Token: 0x060003CD RID: 973 RVA: 0x00011E88 File Offset: 0x00010088
	public void b(bool A_0)
	{
		this.n = A_0;
	}

	// Token: 0x060003CE RID: 974 RVA: 0x00011E94 File Offset: 0x00010094
	public bool b()
	{
		return this.o;
	}

	// Token: 0x060003CF RID: 975 RVA: 0x00011E9C File Offset: 0x0001009C
	public void a(bool A_0)
	{
		this.o = A_0;
	}

	// Token: 0x060003D0 RID: 976 RVA: 0x00011EA8 File Offset: 0x000100A8
	[CompilerGenerated]
	public void avy(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.p;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.p, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060003D1 RID: 977 RVA: 0x00011EE0 File Offset: 0x000100E0
	[CompilerGenerated]
	public void avz(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.p;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.p, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060003D2 RID: 978 RVA: 0x00011F18 File Offset: 0x00010118
	protected e6e(int A_0 = 0)
	{
		this.d = A_0;
	}

	// Token: 0x060003D3 RID: 979 RVA: 0x00011FAC File Offset: 0x000101AC
	public virtual Assembly av0(object A_0, ResolveEventArgs A_1)
	{
		if (!this.e)
		{
			this.av1();
		}
		AssemblyName assemblyName = new AssemblyName(A_1.Name);
		cvq service = bpo.GetService<cvq>();
		if (service != null && service.n8() && service.n9(LogSeverity.Information, this.d))
		{
			string a_ = ki.a("Attempting to resolve assembly '{0}'", new object[]
			{
				assemblyName
			});
			service.n7(LogSeverity.Information, this.d, a_);
		}
		Assembly assembly = null;
		try
		{
			this.b.TryGetValue(A_1.Name, out assembly);
			if (assembly == null)
			{
				if (service != null && service.n8() && service.n9(LogSeverity.Information, this.d))
				{
					string a_2 = ki.a("Assembly path was not found under the full assembly name. Searching by assembly name ('{0}')", new object[]
					{
						assemblyName.Name
					});
					service.n7(LogSeverity.Information, this.d, a_2);
				}
				this.a.TryGetValue(assemblyName.Name, out assembly);
			}
		}
		catch (Exception ex)
		{
			if (service != null && service.n8() && service.n9(LogSeverity.Error, this.d))
			{
				string a_3 = ki.a("An error occured while attempting to load assembly '{0}'. Exception: {1}", new object[]
				{
					assemblyName,
					ex
				});
				service.n7(LogSeverity.Error, this.d, a_3);
			}
		}
		if (assembly == null)
		{
			if (service != null && service.n8() && service.n9(LogSeverity.Warning, this.d))
			{
				string a_4 = ki.a("Failed to resolve assembly '{0}' by both full name and name.", new object[]
				{
					assemblyName
				});
				service.n7(LogSeverity.Warning, this.d, a_4);
			}
		}
		else if (service != null && service.n8() && service.n9(LogSeverity.Information, this.d))
		{
			string a_5 = ki.a("Assembly '{0}' resolved as '{1}'.", new object[]
			{
				assemblyName,
				assembly.FullName
			});
			service.n7(LogSeverity.Information, this.d, a_5);
		}
		return assembly;
	}

	// Token: 0x060003D4 RID: 980 RVA: 0x000121BC File Offset: 0x000103BC
	public void av1()
	{
		cvq service = bpo.GetService<cvq>();
		this.a.Clear();
		this.b.Clear();
		this.c.Clear();
		this.m.Clear();
		this.a();
		if (this.n)
		{
			foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
			{
				this.r3(type);
				this.m.Add(type);
			}
		}
		else
		{
			foreach (KeyValuePair<string, SearchOption> keyValuePair in this.oo())
			{
				string key = keyValuePair.Key;
				SearchOption value = keyValuePair.Value;
				if (Directory.Exists(key))
				{
					string[] files = Directory.GetFiles(key, "*.dll", value);
					string[] files2 = Directory.GetFiles(key, "*.exe", value);
					List<string> list = new List<string>();
					list.AddRange(files);
					list.AddRange(files2);
					foreach (string text in list)
					{
						string text2 = Path.Combine(key, text);
						try
						{
							string fileName = Path.GetFileName(text);
							if (string.Equals(fileName, "steamhelper.dll", StringComparison.OrdinalIgnoreCase) || string.Equals(fileName, "steam_api.dll", StringComparison.OrdinalIgnoreCase))
							{
								continue;
							}
							AssemblyName assemblyName = AssemblyName.GetAssemblyName(text2);
							Assembly assembly = Assembly.Load(assemblyName);
							if (!this.b.ContainsKey(assemblyName.FullName))
							{
								if (assembly == null)
								{
									assembly = Assembly.LoadFrom(text2);
								}
								this.b[assemblyName.FullName] = assembly;
								this.a[assemblyName.Name] = assembly;
								foreach (Type type2 in assembly.GetTypes())
								{
									this.r3(type2);
									this.m.Add(type2);
								}
							}
						}
						catch (Exception ex)
						{
							if (service != null && service.n8() && service.n9(LogSeverity.Error, 0))
							{
								string a_ = string.Format("[RootPathAssemblyResolver] - Failed to process assembly '{0}' at reinitialization. Exception: {1}", text, ex.ToString());
								service.n7(LogSeverity.Error, 0, a_);
							}
							continue;
						}
						this.c.Add(text2);
					}
				}
			}
		}
		if (this.p != null)
		{
			this.p(this, new EventArgs());
		}
		this.e = true;
	}

	// Token: 0x060003D5 RID: 981 RVA: 0x000124AC File Offset: 0x000106AC
	public List<Type> av2(Func<Type, bool> A_0)
	{
		return new List<Type>(Enumerable.Where<Type>(this.m, A_0));
	}

	// Token: 0x060003D6 RID: 982 RVA: 0x000124C0 File Offset: 0x000106C0
	public void d()
	{
		if (!this.e)
		{
			this.av1();
		}
		this.a();
		cvq service = bpo.GetService<cvq>();
		this.a(service);
		string text = "";
		foreach (Type type in this.m)
		{
			try
			{
				this.f[type.FullName] = type;
				eiz eiz = e6e.a(type);
				if (eiz != null && !string.IsNullOrWhiteSpace(eiz.a()))
				{
					if (this.a(eiz.a(), type, service))
					{
						text = text + eiz.a() + " ";
					}
					else
					{
						this.a(type, eiz.a(), ref text, service);
					}
				}
			}
			catch (Exception ex)
			{
				if (service != null && service.n8() && service.n9(LogSeverity.Error, 0))
				{
					string a_ = string.Format("[RootPathAssemblyResolver] - Failed to process type '{0}' while creating data model element type map. Exception: {1}", type.AssemblyQualifiedName, ex.ToString());
					service.n7(LogSeverity.Error, 0, a_);
				}
			}
		}
		if (this.o && !string.IsNullOrEmpty(text))
		{
			throw new Exception("Duplicates found while mapping data model element types: " + text);
		}
	}

	// Token: 0x060003D7 RID: 983 RVA: 0x00012630 File Offset: 0x00010830
	public Type av3(string A_0, string A_1, bool A_2 = true)
	{
		if (ell.b() >= 4 || !ell.c())
		{
			Type type = null;
			if (A_1 == "X")
			{
				this.g.TryGetValue(A_0, out type);
			}
			else if (A_1 == "G")
			{
				this.i.TryGetValue(A_0, out type);
				if (type == null)
				{
					type = this.a(A_0);
					this.i[A_0] = type;
					return type;
				}
			}
			if (type == null)
			{
				type = this.a(A_0, A_1);
				if (type == null)
				{
					string[] array = A_0.Split(new char[]
					{
						','
					}, StringSplitOptions.RemoveEmptyEntries);
					if (array.Length > 1 && (array[1] == " FNA" || array[1] == " WineMono.FNA"))
					{
						string text = array[0];
						if (text == typeof(Point).FullName)
						{
							this.g[A_0] = typeof(Point);
							return typeof(Point);
						}
						if (text == typeof(Vector2).FullName)
						{
							this.g[A_0] = typeof(Vector2);
							return typeof(Vector2);
						}
						if (text == typeof(Vector3).FullName)
						{
							this.g[A_0] = typeof(Vector3);
							return typeof(Vector3);
						}
						if (text == typeof(Color).FullName)
						{
							this.g[A_0] = typeof(Color);
							return typeof(Color);
						}
						if (text == typeof(Matrix).FullName)
						{
							this.g[A_0] = typeof(Matrix);
							return typeof(Matrix);
						}
					}
				}
				if (type == null && A_2)
				{
					throw new Exception("Unable to resolve data element type: " + A_0);
				}
				this.i[A_0] = type;
			}
			return type;
		}
		if (A_0 != null)
		{
			Type result;
			this.g.TryGetValue(A_0, out result);
			return result;
		}
		return null;
	}

	// Token: 0x060003D8 RID: 984 RVA: 0x00012898 File Offset: 0x00010A98
	public string av4(Type A_0)
	{
		string result;
		string text;
		this.av5(A_0, out result, out text, true);
		return result;
	}

	// Token: 0x060003D9 RID: 985 RVA: 0x000128B4 File Offset: 0x00010AB4
	public void av5(Type A_0, out string A_1, out string A_2, bool A_3 = false)
	{
		this.j.TryGetValue(A_0, out A_1);
		if (A_1 != null)
		{
			A_2 = (A_0.IsGenericType ? "G" : "X");
			return;
		}
		if (A_3 && typeof(Delegate).IsAssignableFrom(A_0))
		{
			A_1 = null;
			A_2 = null;
			return;
		}
		if (A_0.IsGenericType || A_0.IsArray)
		{
			A_1 = this.b(A_0);
			A_2 = "G";
			this.j[A_0] = A_1;
			return;
		}
		this.h.TryGetValue(A_0.FullName, out A_1);
		if (A_1 != null)
		{
			A_2 = "X";
			this.j[A_0] = A_1;
			return;
		}
		if (A_3)
		{
			A_1 = null;
			A_2 = null;
			return;
		}
		A_1 = A_0.FullName;
		A_2 = A_0.Assembly.FullName;
	}

	// Token: 0x060003DA RID: 986 RVA: 0x000129A0 File Offset: 0x00010BA0
	public string av6(MethodInfo A_0)
	{
		czh.a(A_0, "methodInfo");
		string result;
		this.k.TryGetValue(A_0, out result);
		return result;
	}

	// Token: 0x060003DB RID: 987 RVA: 0x000129C8 File Offset: 0x00010BC8
	public MethodInfo av7(string A_0)
	{
		czh.a(A_0, "methodElementName");
		MethodInfo result;
		this.l.TryGetValue(A_0, out result);
		return result;
	}

	// Token: 0x060003DC RID: 988
	protected abstract Dictionary<string, SearchOption> oo();

	// Token: 0x060003DD RID: 989 RVA: 0x000129F0 File Offset: 0x00010BF0
	protected virtual void r3(Type A_0)
	{
	}

	// Token: 0x060003DE RID: 990 RVA: 0x000129F4 File Offset: 0x00010BF4
	private void a(cvq A_0)
	{
		this.a("%b%", typeof(bool), A_0);
		this.a("%i%", typeof(int), A_0);
		this.a("%l%", typeof(long), A_0);
		this.a("%f%", typeof(float), A_0);
		this.a("%d%", typeof(double), A_0);
		this.a("%B%", typeof(byte), A_0);
		this.a("%c%", typeof(char), A_0);
		this.a("%s%", typeof(string), A_0);
		this.a("%D%", typeof(decimal), A_0);
		this.a("%G%", typeof(Guid), A_0);
		this.a("%NL%", typeof(Nullable<>), A_0);
		this.a("%DI%", typeof(Dictionary<, >), A_0);
		this.a("%LI%", typeof(List<>), A_0);
		this.a("%HS%", typeof(HashSet), A_0);
		this.a("%HT%", typeof(Hashtable), A_0);
		this.a("%SL%", typeof(SortedList), A_0);
		this.a("%CO%", typeof(Collection<>), A_0);
	}

	// Token: 0x060003DF RID: 991 RVA: 0x00012B88 File Offset: 0x00010D88
	private bool a(string A_0, Type A_1, cvq A_2)
	{
		if (this.h.ContainsKey(A_1.FullName))
		{
			if (A_2 != null && A_2.n8() && A_2.n9(LogSeverity.Error, 0))
			{
				string a_ = string.Format("[RootPathAssemblyResolver] - Duplicate net type to data model element type mapping detected. Net type: {0}; Data element type: {1}.", A_1.FullName, A_0);
				A_2.n7(LogSeverity.Error, 0, a_);
			}
			return true;
		}
		this.h[A_1.FullName] = A_0;
		if (this.g.ContainsKey(A_0))
		{
			if (A_2 != null && A_2.n8() && A_2.n9(LogSeverity.Error, 0))
			{
				string a_2 = string.Format("[RootPathAssemblyResolver] - Duplicate data model element type to net type mapping detected. Net type: {0}; Data element type: {1}.", A_1.FullName, A_0);
				A_2.n7(LogSeverity.Error, 0, a_2);
			}
			return true;
		}
		this.g[A_0] = A_1;
		return false;
	}

	// Token: 0x060003E0 RID: 992 RVA: 0x00012C54 File Offset: 0x00010E54
	private void a()
	{
		this.f.Clear();
		this.h.Clear();
		this.g.Clear();
		this.i.Clear();
		this.j.Clear();
		this.k.Clear();
		this.l.Clear();
	}

	// Token: 0x060003E1 RID: 993 RVA: 0x00012CB0 File Offset: 0x00010EB0
	private Type a(string A_0, string A_1)
	{
		if (A_0.StartsWith("Ouroboros") || A_0.StartsWith("Timelapse") || (A_1 != null && (A_1.StartsWith("Ouroboros") || A_1.StartsWith("Timelapse"))))
		{
			Trace.WriteLine("Resolving uncoded normal type: " + A_0 + ", " + A_1);
		}
		Type type = null;
		Type result;
		try
		{
			if (A_0 != null)
			{
				this.f.TryGetValue(A_0, out type);
				if (type != null)
				{
					return type;
				}
				type = Type.GetType(A_0);
				if (type != null)
				{
					return type;
				}
				if (A_1 != null && A_1.Length > 1)
				{
					type = Type.GetType(A_0 + ", " + A_1);
					if (type != null)
					{
						return type;
					}
				}
				if (Enumerable.Contains<char>(A_0, ','))
				{
					type = Type.GetType(A_0.Split(new char[]
					{
						','
					})[0]);
					return type;
				}
			}
			result = null;
		}
		finally
		{
			if (type != null)
			{
				this.f[A_0] = type;
			}
		}
		return result;
	}

	// Token: 0x060003E2 RID: 994 RVA: 0x00012DF8 File Offset: 0x00010FF8
	private Type a(string A_0)
	{
		if (A_0 != null)
		{
			string[] a_ = A_0.Split(new char[]
			{
				'>'
			});
			int num = 0;
			return this.a(a_, ref num, 1)[0];
		}
		throw new Exception("Null data model symbol encountered.");
	}

	// Token: 0x060003E3 RID: 995 RVA: 0x00012E3C File Offset: 0x0001103C
	private Type[] a(string[] A_0, ref int A_1, int A_2)
	{
		List<Type> list = new List<Type>();
		for (int i = 0; i < A_2; i++)
		{
			string text = A_0[A_1];
			string[] array = text.Split(new char[]
			{
				'#'
			});
			if (array.Length < 1)
			{
				throw new Exception("Cannot decode data model symbol '" + text + "'");
			}
			string a_ = array[0];
			bool flag = a_ == "%A%";
			if (array.Length <= 1)
			{
				throw new Exception("Cannot decode data model symbol '" + text + "'. Missing components.");
			}
			int num;
			bool flag2;
			if (flag)
			{
				if (!int.TryParse(array[1], NumberStyles.Number, CultureInfo.InvariantCulture, out num))
				{
					num = 0;
				}
				flag2 = false;
			}
			else
			{
				char c;
				if (array[1].Length >= 1)
				{
					c = array[1][0];
				}
				else
				{
					c = '-';
				}
				if (c == 'G')
				{
					flag2 = true;
					if (!int.TryParse(array[1].Substring(1), NumberStyles.Number, CultureInfo.InvariantCulture, out num))
					{
						num = 0;
					}
				}
				else
				{
					flag2 = false;
					num = 0;
				}
			}
			if (flag)
			{
				if (num <= 0)
				{
					throw new Exception("Cannot decode data model symbol '" + text + "'. Invalid array rank.");
				}
				if (A_1 + 1 >= A_0.Length)
				{
					throw new Exception("Cannot decode data model symbol '" + text + "'. Unexpected end of sequence.");
				}
				A_1++;
				Type type = this.a(A_0, ref A_1, 1)[0];
				Type item;
				if (num > 1)
				{
					item = type.MakeArrayType(num);
				}
				else
				{
					item = type.MakeArrayType();
				}
				list.Add(item);
			}
			else if (flag2 && num > 0)
			{
				Type type2 = this.av3(a_, "X", true);
				if (A_1 + num >= A_0.Length)
				{
					throw new Exception("Cannot decode data model symbol '" + text + "'. Unexpected end of sequence.");
				}
				A_1++;
				Type[] typeArguments = this.a(A_0, ref A_1, num);
				Type item2 = type2.MakeGenericType(typeArguments);
				list.Add(item2);
			}
			else
			{
				list.Add(this.av3(a_, "X", true));
				A_1++;
			}
		}
		return list.ToArray();
	}

	// Token: 0x060003E4 RID: 996 RVA: 0x00013084 File Offset: 0x00011284
	private string b(Type A_0)
	{
		string text;
		if (A_0.IsGenericType)
		{
			Type genericTypeDefinition = A_0.GetGenericTypeDefinition();
			string str = this.a(genericTypeDefinition);
			Type[] genericArguments = A_0.GetGenericArguments();
			text = str + "#G" + genericArguments.Length.ToString();
			foreach (Type a_ in genericArguments)
			{
				text = text + ">" + this.b(a_);
			}
		}
		else if (A_0.IsArray)
		{
			text = "%A%#" + A_0.GetArrayRank().ToString() + ">" + this.b(A_0.GetElementType());
		}
		else
		{
			text = this.a(A_0) + "#-";
		}
		return text;
	}

	// Token: 0x060003E5 RID: 997 RVA: 0x0001314C File Offset: 0x0001134C
	public string b(string A_0)
	{
		string result;
		this.h.TryGetValue(A_0, out result);
		return result;
	}

	// Token: 0x060003E6 RID: 998 RVA: 0x0001316C File Offset: 0x0001136C
	private string a(Type A_0)
	{
		string assemblyQualifiedName;
		this.h.TryGetValue(A_0.FullName, out assemblyQualifiedName);
		if (assemblyQualifiedName == null)
		{
			assemblyQualifiedName = A_0.AssemblyQualifiedName;
		}
		return assemblyQualifiedName;
	}

	// Token: 0x060003E7 RID: 999 RVA: 0x0001319C File Offset: 0x0001139C
	private void a(Type A_0, string A_1, ref string A_2, cvq A_3)
	{
		foreach (MethodInfo methodInfo in A_0.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
		{
			dcc dcc = e6e.a(methodInfo);
			if (dcc != null && !string.IsNullOrEmpty(dcc.a()))
			{
				string text = A_1 + ":" + dcc.a();
				this.k[methodInfo] = text;
				if (this.l.ContainsKey(text))
				{
					if (A_3 != null && A_3.n8() && A_3.n9(LogSeverity.Error, 0))
					{
						string a_ = string.Format("[RootPathAssemblyResolver] - Duplicate data model method element mapping detected. Method: {0}; Element type: {1}.", methodInfo, text);
						A_3.n7(LogSeverity.Error, 0, a_);
					}
					A_2 = A_2 + text + " ";
				}
				else
				{
					this.l.Add(text, methodInfo);
				}
			}
		}
	}

	// Token: 0x060003E8 RID: 1000 RVA: 0x0001327C File Offset: 0x0001147C
	private static eiz a(MemberInfo A_0)
	{
		return Enumerable.FirstOrDefault<object>(A_0.GetCustomAttributes(typeof(eiz), false)) as eiz;
	}

	// Token: 0x060003E9 RID: 1001 RVA: 0x0001329C File Offset: 0x0001149C
	private static dcc a(MethodInfo A_0)
	{
		return Enumerable.FirstOrDefault<object>(A_0.GetCustomAttributes(typeof(dcc), true)) as dcc;
	}

	// Token: 0x04000420 RID: 1056
	private Dictionary<string, Assembly> a = new Dictionary<string, Assembly>();

	// Token: 0x04000421 RID: 1057
	private Dictionary<string, Assembly> b = new Dictionary<string, Assembly>();

	// Token: 0x04000422 RID: 1058
	private List<string> c = new List<string>();

	// Token: 0x04000423 RID: 1059
	private int d;

	// Token: 0x04000424 RID: 1060
	private bool e;

	// Token: 0x04000425 RID: 1061
	private Dictionary<string, Type> f = new Dictionary<string, Type>();

	// Token: 0x04000426 RID: 1062
	private Dictionary<string, Type> g = new Dictionary<string, Type>();

	// Token: 0x04000427 RID: 1063
	private Dictionary<string, string> h = new Dictionary<string, string>();

	// Token: 0x04000428 RID: 1064
	private Dictionary<string, Type> i = new Dictionary<string, Type>();

	// Token: 0x04000429 RID: 1065
	private Dictionary<Type, string> j = new Dictionary<Type, string>();

	// Token: 0x0400042A RID: 1066
	private Dictionary<MethodInfo, string> k = new Dictionary<MethodInfo, string>();

	// Token: 0x0400042B RID: 1067
	private Dictionary<string, MethodInfo> l = new Dictionary<string, MethodInfo>();

	// Token: 0x0400042C RID: 1068
	private List<Type> m = new List<Type>();

	// Token: 0x0400042D RID: 1069
	private bool n;

	// Token: 0x0400042E RID: 1070
	private bool o;

	// Token: 0x0400042F RID: 1071
	[CompilerGenerated]
	private EventHandler<EventArgs> p;
}
