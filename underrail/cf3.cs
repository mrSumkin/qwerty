using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;

// Token: 0x02000089 RID: 137
internal abstract class cf3
{
	// Token: 0x0600033E RID: 830 RVA: 0x0000EEB8 File Offset: 0x0000D0B8
	public cf3(Stream A_0, dps A_1)
	{
		if (A_0 == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (A_1 == null)
		{
			throw new ArgumentNullException("formatter");
		}
		this.d = A_0;
		this.a = A_1.get_Binder();
		this.b = A_1.get_Context();
		this.c = A_1.get_SurrogateSelector();
		this.e = A_1.a();
		this.f = new object[0];
		this.g = new Dictionary<Type, MemberInfo[]>();
		this.h = new Dictionary<cf3.a, IList<MethodInfo>>();
		this.i = new Dictionary<Type, ISerializationSurrogate>();
	}

	// Token: 0x0600033F RID: 831 RVA: 0x0000EF54 File Offset: 0x0000D154
	protected static void AccommodateList<T>(List<T> list, int lastIndex)
	{
		if (list == null)
		{
			throw new ArgumentNullException("list");
		}
		for (int i = list.Count; i <= lastIndex; i++)
		{
			list.Add(default(T));
		}
	}

	// Token: 0x06000340 RID: 832 RVA: 0x0000EF98 File Offset: 0x0000D198
	protected static void a(Array A_0, Action<Array, int[]> A_1)
	{
		if (A_0 == null)
		{
			throw new ArgumentNullException("array");
		}
		if (A_1 == null)
		{
			throw new ArgumentNullException("action");
		}
		int rank = A_0.Rank;
		int[] array = new int[rank];
		for (int i = 0; i < array.Length; i++)
		{
			int lowerBound = A_0.GetLowerBound(i);
			int upperBound = A_0.GetUpperBound(i);
			if (lowerBound > upperBound)
			{
				return;
			}
			array[i] = lowerBound;
		}
		bool flag;
		do
		{
			A_1(A_0, array);
			flag = false;
			for (int j = 0; j < rank; j++)
			{
				int num = array[j];
				int upperBound2 = A_0.GetUpperBound(j);
				if (++num <= upperBound2)
				{
					array[j] = num;
					flag = true;
					break;
				}
				array[j] = A_0.GetLowerBound(j);
			}
		}
		while (flag);
	}

	// Token: 0x06000341 RID: 833 RVA: 0x0000F064 File Offset: 0x0000D264
	protected ISerializationSurrogate f(Type A_0)
	{
		if (A_0 == null)
		{
			throw new ArgumentNullException("type");
		}
		if (this.c == null)
		{
			return null;
		}
		ISerializationSurrogate surrogate;
		if (!this.i.TryGetValue(A_0, out surrogate))
		{
			ISurrogateSelector surrogateSelector;
			surrogate = this.c.GetSurrogate(A_0, this.b, ref surrogateSelector);
			this.i[A_0] = surrogate;
		}
		return surrogate;
	}

	// Token: 0x06000342 RID: 834 RVA: 0x0000F0CC File Offset: 0x0000D2CC
	protected void a(object A_0, Type A_1)
	{
		if (A_1 == null)
		{
			throw new ArgumentNullException("attributeType");
		}
		if (A_0 == null)
		{
			return;
		}
		Type type = A_0.GetType();
		IList<MethodInfo> list = this.a(type, A_1);
		for (int i = 0; i < list.Count; i++)
		{
			list[i].Invoke(A_0, new object[]
			{
				this.b
			});
		}
	}

	// Token: 0x06000343 RID: 835 RVA: 0x0000F140 File Offset: 0x0000D340
	protected IList<MethodInfo> a(Type A_0, Type A_1)
	{
		if (A_0 == null)
		{
			throw new ArgumentNullException("type");
		}
		if (A_1 == null)
		{
			throw new ArgumentNullException("attributeType");
		}
		cf3.a key = new cf3.a
		{
			a = A_0,
			b = A_1
		};
		IList<MethodInfo> list;
		if (!this.h.TryGetValue(key, out list))
		{
			MethodInfo[] methods = A_0.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			list = new List<MethodInfo>(methods.Length);
			foreach (MethodInfo methodInfo in methods)
			{
				if (methodInfo.GetCustomAttributes(A_1, true).Length != 0)
				{
					ParameterInfo[] parameters = methodInfo.GetParameters();
					if (parameters.Length != 1 || parameters[0].ParameterType != typeof(StreamingContext))
					{
						throw new SerializationException(string.Format("The method '{0}' attributed with '{1}' expects a single SerializationContext parameter.", methodInfo.Name, A_1.Name));
					}
					list.Add(methodInfo);
				}
			}
			this.h.Add(key, list);
		}
		return list;
	}

	// Token: 0x06000344 RID: 836 RVA: 0x0000F250 File Offset: 0x0000D450
	protected void e(Type A_0)
	{
		if (A_0 == null)
		{
			throw new ArgumentNullException("type");
		}
		while (A_0 != null)
		{
			if (!A_0.IsEnum && !A_0.IsInterface && A_0.GetCustomAttributes(typeof(SerializableAttribute), false).Length == 0)
			{
				throw new SerializationException(string.Format("The type '{0}' is not marked with SerializableAttribute.", A_0.FullName));
			}
			A_0 = A_0.BaseType;
		}
	}

	// Token: 0x06000345 RID: 837 RVA: 0x0000F2C8 File Offset: 0x0000D4C8
	protected MemberInfo[] g(Type A_0)
	{
		if (A_0 == null)
		{
			throw new ArgumentNullException("type");
		}
		MemberInfo[] serializableMembers;
		if (!this.g.TryGetValue(A_0, out serializableMembers))
		{
			serializableMembers = FormatterServices.GetSerializableMembers(A_0, this.b);
			this.g[A_0] = serializableMembers;
		}
		return serializableMembers;
	}

	// Token: 0x040003F3 RID: 1011
	protected SerializationBinder a;

	// Token: 0x040003F4 RID: 1012
	protected StreamingContext b;

	// Token: 0x040003F5 RID: 1013
	protected ISurrogateSelector c;

	// Token: 0x040003F6 RID: 1014
	protected Stream d;

	// Token: 0x040003F7 RID: 1015
	protected IFormatterConverter e;

	// Token: 0x040003F8 RID: 1016
	protected object[] f;

	// Token: 0x040003F9 RID: 1017
	private Dictionary<Type, MemberInfo[]> g;

	// Token: 0x040003FA RID: 1018
	private Dictionary<cf3.a, IList<MethodInfo>> h;

	// Token: 0x040003FB RID: 1019
	private Dictionary<Type, ISerializationSurrogate> i;

	// Token: 0x0200008A RID: 138
	private struct a
	{
		// Token: 0x06000346 RID: 838 RVA: 0x0000F31C File Offset: 0x0000D51C
		public override int GetHashCode()
		{
			return 23 * this.b.GetHashCode() + this.a.GetHashCode();
		}

		// Token: 0x040003FC RID: 1020
		public Type a;

		// Token: 0x040003FD RID: 1021
		public Type b;
	}
}
