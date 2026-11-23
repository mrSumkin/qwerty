using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x0200008B RID: 139
internal class be3 : cf3
{
	// Token: 0x06000347 RID: 839 RVA: 0x0000F338 File Offset: 0x0000D538
	public be3(Stream A_0, dps A_1) : base(A_0, A_1)
	{
		this.a = new Dictionary<Type, int>();
		this.b = new Dictionary<be3.a, int>();
		this.c = new Dictionary<string, int>();
		this.d = A_1.b();
	}

	// Token: 0x06000348 RID: 840 RVA: 0x0000F370 File Offset: 0x0000D570
	public new void c(object A_0)
	{
		this.b(A_0);
	}

	// Token: 0x06000349 RID: 841 RVA: 0x0000F37C File Offset: 0x0000D57C
	private new void b(string A_0)
	{
		if (A_0 == null)
		{
			throw new ArgumentNullException("text");
		}
		char[] array = A_0.ToCharArray();
		byte[] bytes = BitConverter.GetBytes(array.Length);
		this.d.Write(bytes, 0, 4);
		byte[] array2 = new byte[array.Length * 2];
		int num = 0;
		foreach (char c in array)
		{
			array2[num++] = (byte)c;
			array2[num++] = (byte)(c >> 8);
		}
		this.d.Write(array2, 0, array2.Length);
	}

	// Token: 0x0600034A RID: 842 RVA: 0x0000F408 File Offset: 0x0000D608
	private new void a(string A_0)
	{
		if (A_0 == null)
		{
			throw new ArgumentNullException("text");
		}
		int num;
		if (this.c.TryGetValue(A_0, out num))
		{
			this.a(num);
			return;
		}
		num = (this.c.Count | int.MinValue);
		this.c[A_0] = num;
		this.a(num);
		this.b(A_0);
	}

	// Token: 0x0600034B RID: 843 RVA: 0x0000F470 File Offset: 0x0000D670
	private new void a(bool A_0)
	{
		if (A_0)
		{
			this.d.WriteByte(1);
			return;
		}
		this.d.WriteByte(0);
	}

	// Token: 0x0600034C RID: 844 RVA: 0x0000F494 File Offset: 0x0000D694
	private new void a(byte A_0)
	{
		this.d.WriteByte(A_0);
	}

	// Token: 0x0600034D RID: 845 RVA: 0x0000F4A8 File Offset: 0x0000D6A8
	private new void a(char A_0)
	{
		byte[] bytes = BitConverter.GetBytes(A_0);
		this.d.Write(bytes, 0, 2);
	}

	// Token: 0x0600034E RID: 846 RVA: 0x0000F4CC File Offset: 0x0000D6CC
	private new void a(DateTime A_0)
	{
		this.a(A_0.Ticks);
	}

	// Token: 0x0600034F RID: 847 RVA: 0x0000F4E0 File Offset: 0x0000D6E0
	private new void a(decimal A_0)
	{
		int[] bits = decimal.GetBits(A_0);
		this.a(bits[0]);
		this.a(bits[1]);
		this.a(bits[2]);
		this.a(bits[3]);
	}

	// Token: 0x06000350 RID: 848 RVA: 0x0000F518 File Offset: 0x0000D718
	private new void a(double A_0)
	{
		byte[] bytes = BitConverter.GetBytes(A_0);
		this.d.Write(bytes, 0, 8);
	}

	// Token: 0x06000351 RID: 849 RVA: 0x0000F53C File Offset: 0x0000D73C
	private new void a(short A_0)
	{
		byte[] bytes = BitConverter.GetBytes(A_0);
		this.d.Write(bytes, 0, 2);
	}

	// Token: 0x06000352 RID: 850 RVA: 0x0000F560 File Offset: 0x0000D760
	private new void a(int A_0)
	{
		byte[] bytes = BitConverter.GetBytes(A_0);
		this.d.Write(bytes, 0, 4);
	}

	// Token: 0x06000353 RID: 851 RVA: 0x0000F584 File Offset: 0x0000D784
	private new void a(long A_0)
	{
		byte[] bytes = BitConverter.GetBytes(A_0);
		this.d.Write(bytes, 0, 8);
	}

	// Token: 0x06000354 RID: 852 RVA: 0x0000F5A8 File Offset: 0x0000D7A8
	private new void a(sbyte A_0)
	{
		this.d.WriteByte((byte)A_0);
	}

	// Token: 0x06000355 RID: 853 RVA: 0x0000F5BC File Offset: 0x0000D7BC
	private new void a(float A_0)
	{
		byte[] bytes = BitConverter.GetBytes(A_0);
		this.d.Write(bytes, 0, 4);
	}

	// Token: 0x06000356 RID: 854 RVA: 0x0000F5E0 File Offset: 0x0000D7E0
	private new void a(TimeSpan A_0)
	{
		this.a(A_0.Ticks);
	}

	// Token: 0x06000357 RID: 855 RVA: 0x0000F5F4 File Offset: 0x0000D7F4
	private new void a(ushort A_0)
	{
		byte[] bytes = BitConverter.GetBytes(A_0);
		this.d.Write(bytes, 0, 2);
	}

	// Token: 0x06000358 RID: 856 RVA: 0x0000F618 File Offset: 0x0000D818
	private new void a(uint A_0)
	{
		byte[] bytes = BitConverter.GetBytes(A_0);
		this.d.Write(bytes, 0, 4);
	}

	// Token: 0x06000359 RID: 857 RVA: 0x0000F63C File Offset: 0x0000D83C
	private new void a(ulong A_0)
	{
		byte[] bytes = BitConverter.GetBytes(A_0);
		this.d.Write(bytes, 0, 8);
	}

	// Token: 0x0600035A RID: 858 RVA: 0x0000F660 File Offset: 0x0000D860
	private new void b(object A_0)
	{
		if (A_0 == null)
		{
			this.a(0);
			return;
		}
		Type type = A_0.GetType();
		int a_;
		if (!type.IsValueType && this.b.TryGetValue(new be3.a(A_0), out a_))
		{
			this.a(5);
			this.a(a_);
			return;
		}
		if (type.IsArray)
		{
			this.a(3);
			Type elementType = type.GetElementType();
			this.a(elementType);
			this.a(A_0);
			Array array = (Array)A_0;
			this.a(array.Rank);
			for (int i = 0; i < array.Rank; i++)
			{
				int lowerBound = array.GetLowerBound(i);
				int length = array.GetLength(i);
				this.a(lowerBound);
				this.a(length);
			}
			cf3.a(array, new Action<Array, int[]>(this.a));
			return;
		}
		this.a(4);
		ISerializationSurrogate serializationSurrogate = base.f(type);
		if (serializationSurrogate != null)
		{
			SerializationInfo serializationInfo = new SerializationInfo(type, this.e);
			base.a(A_0, typeof(OnSerializingAttribute));
			serializationSurrogate.GetObjectData(A_0, serializationInfo, this.b);
			this.a(A_0, serializationInfo);
			base.a(A_0, typeof(OnSerializedAttribute));
			return;
		}
		ISerializable serializable = A_0 as ISerializable;
		if (serializable != null)
		{
			SerializationInfo serializationInfo2 = new SerializationInfo(type, this.e);
			base.a(A_0, typeof(OnSerializingAttribute));
			serializable.GetObjectData(serializationInfo2, this.b);
			this.a(A_0, serializationInfo2);
			base.a(A_0, typeof(OnSerializedAttribute));
			return;
		}
		this.a(type);
		if (type.IsValueType)
		{
			if (type.IsEnum)
			{
				Type enumUnderlyingType = type.GetEnumUnderlyingType();
				if (enumUnderlyingType == typeof(byte))
				{
					this.a(Convert.ToByte(A_0));
					return;
				}
				if (enumUnderlyingType == typeof(short))
				{
					this.a(Convert.ToInt16(A_0));
					return;
				}
				if (enumUnderlyingType == typeof(int))
				{
					this.a(Convert.ToInt32(A_0));
					return;
				}
				if (enumUnderlyingType == typeof(long))
				{
					this.a(Convert.ToInt64(A_0));
					return;
				}
				if (enumUnderlyingType == typeof(sbyte))
				{
					this.a(Convert.ToSByte(A_0));
					return;
				}
				if (enumUnderlyingType == typeof(ushort))
				{
					this.a(Convert.ToUInt16(A_0));
					return;
				}
				if (enumUnderlyingType == typeof(uint))
				{
					this.a(Convert.ToUInt32(A_0));
					return;
				}
				if (enumUnderlyingType == typeof(ulong))
				{
					this.a(Convert.ToUInt64(A_0));
					return;
				}
				throw new SerializationException(string.Format("Unsupported underlying type '{0}' of enum type '{1}'.", enumUnderlyingType.FullName, type.FullName));
			}
			else
			{
				if (type == typeof(bool))
				{
					this.a((bool)A_0);
					return;
				}
				if (type == typeof(byte))
				{
					this.a((byte)A_0);
					return;
				}
				if (type == typeof(char))
				{
					this.a((char)A_0);
					return;
				}
				if (type == typeof(decimal))
				{
					this.a((decimal)A_0);
					return;
				}
				if (type == typeof(double))
				{
					this.a((double)A_0);
					return;
				}
				if (type == typeof(short))
				{
					this.a((short)A_0);
					return;
				}
				if (type == typeof(int))
				{
					this.a((int)A_0);
					return;
				}
				if (type == typeof(long))
				{
					this.a((long)A_0);
					return;
				}
				if (type == typeof(sbyte))
				{
					this.a((sbyte)A_0);
					return;
				}
				if (type == typeof(float))
				{
					this.a((float)A_0);
					return;
				}
				if (type == typeof(TimeSpan))
				{
					this.a((TimeSpan)A_0);
					return;
				}
				if (type == typeof(ushort))
				{
					this.a((ushort)A_0);
					return;
				}
				if (type == typeof(uint))
				{
					this.a((uint)A_0);
					return;
				}
				if (type == typeof(ulong))
				{
					this.a((ulong)A_0);
					return;
				}
				if (type.IsEnum)
				{
					type.GetEnumUnderlyingType();
				}
			}
		}
		else
		{
			this.a(A_0);
		}
		if (type == typeof(string))
		{
			this.b((string)A_0);
			return;
		}
		base.a(A_0, typeof(OnSerializingAttribute));
		MemberInfo[] array2 = base.g(type);
		this.a(array2.Length);
		object[] objectData = FormatterServices.GetObjectData(A_0, array2);
		for (int j = 0; j < array2.Length; j++)
		{
			string name = array2[j].Name;
			if (this.d)
			{
				this.a(name);
			}
			else
			{
				this.b(name);
			}
			this.b(objectData[j]);
		}
		base.a(A_0, typeof(OnSerializedAttribute));
	}

	// Token: 0x0600035B RID: 859 RVA: 0x0000FC00 File Offset: 0x0000DE00
	private new void a(object A_0)
	{
		int num;
		if (!A_0.GetType().IsValueType)
		{
			num = this.b.Count;
			try
			{
				this.b.Add(new be3.a(A_0), num);
				goto IL_42;
			}
			catch (ArgumentException innerException)
			{
				throw new SerializationException("The object already exists in the object ID dictionary.", innerException);
			}
		}
		num = -1;
		IL_42:
		this.a(num);
	}

	// Token: 0x0600035C RID: 860 RVA: 0x0000FC68 File Offset: 0x0000DE68
	private new void a(object A_0, SerializationInfo A_1)
	{
		this.a(A_1.ObjectType);
		if (!A_0.GetType().IsValueType)
		{
			this.a(A_0);
		}
		this.a(A_1.MemberCount);
		foreach (SerializationEntry serializationEntry in A_1)
		{
			if (this.d)
			{
				this.a(serializationEntry.Name);
			}
			else
			{
				this.b(serializationEntry.Name);
			}
			this.b(serializationEntry.Value);
		}
	}

	// Token: 0x0600035D RID: 861 RVA: 0x0000FCF8 File Offset: 0x0000DEF8
	private new void a(Type A_0)
	{
		int count;
		if (this.a.TryGetValue(A_0, out count))
		{
			this.a(2);
			this.a(count);
			return;
		}
		base.e(A_0);
		count = this.a.Count;
		this.a.Add(A_0, count);
		this.a(1);
		this.a(count);
		string text = null;
		string text2 = null;
		this.a.BindToName(A_0, ref text2, ref text);
		if (text2 == null)
		{
			text2 = A_0.Assembly.FullName;
		}
		if (text == null)
		{
			text = A_0.FullName;
		}
		this.b(text2);
		this.b(text);
	}

	// Token: 0x0600035E RID: 862 RVA: 0x0000FD98 File Offset: 0x0000DF98
	[CompilerGenerated]
	private new void a(Array A_0, int[] A_1)
	{
		this.b(A_0.GetValue(A_1));
	}

	// Token: 0x040003FE RID: 1022
	private new Dictionary<Type, int> a;

	// Token: 0x040003FF RID: 1023
	private new Dictionary<be3.a, int> b;

	// Token: 0x04000400 RID: 1024
	private new Dictionary<string, int> c;

	// Token: 0x04000401 RID: 1025
	private new bool d;

	// Token: 0x0200008C RID: 140
	private new struct a : IEquatable<be3.a>
	{
		// Token: 0x0600035F RID: 863 RVA: 0x0000FDA8 File Offset: 0x0000DFA8
		public a(object A_0)
		{
			this.a = A_0;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0000FDB4 File Offset: 0x0000DFB4
		public object a()
		{
			return this.a;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0000FDBC File Offset: 0x0000DFBC
		public override int GetHashCode()
		{
			if (this.a() == null)
			{
				return 0;
			}
			return RuntimeHelpers.GetHashCode(this.a());
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000FDD8 File Offset: 0x0000DFD8
		public override bool Equals(object obj)
		{
			return base.Equals((be3.a)obj);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0000FDF8 File Offset: 0x0000DFF8
		public bool Equals(be3.a other)
		{
			return this.a() == other.a();
		}

		// Token: 0x04000402 RID: 1026
		private object a;
	}
}
