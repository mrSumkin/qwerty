using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x02000088 RID: 136
internal class ctc : cf3
{
	// Token: 0x0600031E RID: 798 RVA: 0x0000DFA8 File Offset: 0x0000C1A8
	public ctc(Stream A_0, dps A_1) : base(A_0, A_1)
	{
		this.a = new List<IDeserializationCallback>();
		this.b = new List<Type>();
		this.c = new List<object>();
		this.d = new HashSet<int>();
		this.e = new Dictionary<Type, ConstructorInfo>();
		this.f = new Dictionary<Type, ConstructorInfo>();
		this.g = new Dictionary<MemberInfo, bool>();
		this.h = new List<string>();
	}

	// Token: 0x0600031F RID: 799 RVA: 0x0000E018 File Offset: 0x0000C218
	public object t()
	{
		object result = this.c();
		for (int i = 0; i < this.a.Count; i++)
		{
			this.a[i].OnDeserialization(this);
		}
		this.a.Clear();
		return result;
	}

	// Token: 0x06000320 RID: 800 RVA: 0x0000E064 File Offset: 0x0000C264
	private string s()
	{
		byte[] array = new byte[4];
		this.a(array, 0, 4);
		int num = BitConverter.ToInt32(array, 0);
		if (num < 0)
		{
			int num2 = num & int.MaxValue;
			if (num2 < this.h.Count)
			{
				return this.h[num2];
			}
			string text = this.s();
			cf3.AccommodateList<string>(this.h, num2);
			this.h[num2] = text;
			return text;
		}
		else
		{
			if (num == 0)
			{
				return string.Empty;
			}
			byte[] array2 = new byte[2 * num];
			this.a(array2, 0, 2 * num);
			int num3 = 0;
			char[] array3 = new char[num];
			for (int i = 0; i < array3.Length; i++)
			{
				int num4 = (int)array2[num3++];
				byte b = array2[num3++];
				char c = (char)(num4 | (int)b << 8);
				array3[i] = c;
			}
			return new string(array3);
		}
	}

	// Token: 0x06000321 RID: 801 RVA: 0x0000E148 File Offset: 0x0000C348
	private bool r()
	{
		return this.a() > 0;
	}

	// Token: 0x06000322 RID: 802 RVA: 0x0000E154 File Offset: 0x0000C354
	private byte q()
	{
		return this.a();
	}

	// Token: 0x06000323 RID: 803 RVA: 0x0000E160 File Offset: 0x0000C360
	private char p()
	{
		byte[] array = new byte[2];
		this.a(array, 0, 2);
		return BitConverter.ToChar(array, 0);
	}

	// Token: 0x06000324 RID: 804 RVA: 0x0000E184 File Offset: 0x0000C384
	private DateTime o()
	{
		return DateTime.FromBinary(this.j());
	}

	// Token: 0x06000325 RID: 805 RVA: 0x0000E194 File Offset: 0x0000C394
	private decimal n()
	{
		return new decimal(new int[]
		{
			this.k(),
			this.k(),
			this.k(),
			this.k()
		});
	}

	// Token: 0x06000326 RID: 806 RVA: 0x0000E1D0 File Offset: 0x0000C3D0
	private double m()
	{
		byte[] array = new byte[8];
		this.a(array, 0, 8);
		return BitConverter.ToDouble(array, 0);
	}

	// Token: 0x06000327 RID: 807 RVA: 0x0000E1F4 File Offset: 0x0000C3F4
	private short l()
	{
		byte[] array = new byte[2];
		this.a(array, 0, 2);
		return BitConverter.ToInt16(array, 0);
	}

	// Token: 0x06000328 RID: 808 RVA: 0x0000E218 File Offset: 0x0000C418
	private int k()
	{
		byte[] array = new byte[4];
		this.a(array, 0, 4);
		return BitConverter.ToInt32(array, 0);
	}

	// Token: 0x06000329 RID: 809 RVA: 0x0000E23C File Offset: 0x0000C43C
	private long j()
	{
		byte[] array = new byte[8];
		this.a(array, 0, 8);
		return BitConverter.ToInt64(array, 0);
	}

	// Token: 0x0600032A RID: 810 RVA: 0x0000E260 File Offset: 0x0000C460
	private sbyte i()
	{
		return (sbyte)this.a();
	}

	// Token: 0x0600032B RID: 811 RVA: 0x0000E26C File Offset: 0x0000C46C
	private float h()
	{
		byte[] array = new byte[4];
		this.a(array, 0, 4);
		return BitConverter.ToSingle(array, 0);
	}

	// Token: 0x0600032C RID: 812 RVA: 0x0000E290 File Offset: 0x0000C490
	private TimeSpan g()
	{
		return new TimeSpan(this.j());
	}

	// Token: 0x0600032D RID: 813 RVA: 0x0000E2A0 File Offset: 0x0000C4A0
	private new ushort f()
	{
		byte[] array = new byte[2];
		this.a(array, 0, 2);
		return BitConverter.ToUInt16(array, 0);
	}

	// Token: 0x0600032E RID: 814 RVA: 0x0000E2C4 File Offset: 0x0000C4C4
	private new uint e()
	{
		byte[] array = new byte[4];
		this.a(array, 0, 4);
		return BitConverter.ToUInt32(array, 0);
	}

	// Token: 0x0600032F RID: 815 RVA: 0x0000E2E8 File Offset: 0x0000C4E8
	private new ulong d()
	{
		byte[] array = new byte[8];
		this.a(array, 0, 8);
		return BitConverter.ToUInt64(array, 0);
	}

	// Token: 0x06000330 RID: 816 RVA: 0x0000E30C File Offset: 0x0000C50C
	private new object c()
	{
		r8 r = (r8)this.q();
		switch (r)
		{
		case r8.a:
			return null;
		case r8.d:
		{
			Type elementType = this.b();
			int num = this.k();
			int num2 = this.k();
			int[] array = new int[num2];
			int[] array2 = new int[num2];
			for (int i = 0; i < num2; i++)
			{
				array[i] = this.k();
				array2[i] = this.k();
			}
			Array array3 = Array.CreateInstance(elementType, array2, array);
			this.a(num, array3);
			cf3.a(array3, new Action<Array, int[]>(this.a));
			return array3;
		}
		case r8.e:
		{
			Type type = this.b();
			object obj;
			if (type.IsEnum)
			{
				Type enumUnderlyingType = type.GetEnumUnderlyingType();
				if (enumUnderlyingType == typeof(byte))
				{
					obj = Enum.ToObject(type, this.q());
				}
				else if (enumUnderlyingType == typeof(short))
				{
					obj = Enum.ToObject(type, this.l());
				}
				else if (enumUnderlyingType == typeof(int))
				{
					obj = Enum.ToObject(type, this.k());
				}
				else if (enumUnderlyingType == typeof(long))
				{
					obj = Enum.ToObject(type, this.j());
				}
				else if (enumUnderlyingType == typeof(sbyte))
				{
					obj = Enum.ToObject(type, this.i());
				}
				else if (enumUnderlyingType == typeof(ushort))
				{
					obj = Enum.ToObject(type, this.f());
				}
				else if (enumUnderlyingType == typeof(uint))
				{
					obj = Enum.ToObject(type, this.e());
				}
				else
				{
					if (!(enumUnderlyingType == typeof(ulong)))
					{
						throw new SerializationException(string.Format("Unsupported underlying type '{0}' of enum type '{1}'.", enumUnderlyingType.FullName, type.FullName));
					}
					obj = Enum.ToObject(type, this.d());
				}
			}
			else if (type == typeof(bool))
			{
				obj = this.r();
			}
			else if (type == typeof(byte))
			{
				obj = this.q();
			}
			else if (type == typeof(char))
			{
				obj = this.p();
			}
			else if (type == typeof(decimal))
			{
				obj = this.n();
			}
			else if (type == typeof(double))
			{
				obj = this.m();
			}
			else if (type == typeof(short))
			{
				obj = this.l();
			}
			else if (type == typeof(int))
			{
				obj = this.k();
			}
			else if (type == typeof(long))
			{
				obj = this.j();
			}
			else if (type == typeof(sbyte))
			{
				obj = this.i();
			}
			else if (type == typeof(float))
			{
				obj = this.h();
			}
			else if (type == typeof(TimeSpan))
			{
				obj = this.g();
			}
			else if (type == typeof(ushort))
			{
				obj = this.f();
			}
			else if (type == typeof(uint))
			{
				obj = this.e();
			}
			else if (type == typeof(ulong))
			{
				obj = this.d();
			}
			else
			{
				int num;
				if (!type.IsValueType)
				{
					num = this.k();
				}
				else
				{
					num = -1;
				}
				if (type == typeof(string))
				{
					obj = this.s();
					this.a(num, obj);
				}
				else
				{
					ISerializationSurrogate serializationSurrogate = base.f(type);
					if (serializationSurrogate != null)
					{
						SerializationInfo serializationInfo = this.a(type);
						obj = FormatterServices.GetUninitializedObject(type);
						if (num != -1)
						{
							this.a(num, obj);
							this.b(num);
						}
						object obj2 = serializationSurrogate.SetObjectData(obj, serializationInfo, this.b, this.c);
						if (obj2 != null && obj2 != obj)
						{
							obj = obj2;
							if (num != -1)
							{
								if (!this.a(num))
								{
									throw new SerializationException(string.Format("Deserialization of '{0}' using surrogate '{1}' resulted in cyclical reference while the surrogate's SetObjectData returned a different object than the supplied one. This is the unsupported scenario of FastBinaryFormatter.", type.FullName, serializationSurrogate.GetType().FullName));
								}
								this.a(num, obj);
							}
						}
						else if (num != -1)
						{
							this.a(num);
						}
						base.a(obj, typeof(OnDeserializedAttribute));
					}
					else if (typeof(IObjectReference).IsAssignableFrom(type))
					{
						SerializationInfo a_ = this.a(type);
						if (num != -1)
						{
							this.b(num);
						}
						IObjectReference objectReference = this.a(type, a_);
						if (num != -1)
						{
							if (!this.a(num))
							{
								throw new SerializationException(string.Format("Deserialization using IObjectReference implementation '{1}' resulted in cyclical reference.This is the unsupported scenario of FastBinaryFormatter.", type.FullName));
							}
							this.a(num, objectReference);
						}
						obj = objectReference.GetRealObject(this.b);
						base.a(obj, typeof(OnDeserializedAttribute));
					}
					else if (typeof(ISerializable).IsAssignableFrom(type))
					{
						MethodBase methodBase = this.d(type);
						obj = FormatterServices.GetUninitializedObject(type);
						if (num != -1)
						{
							this.a(num, obj);
						}
						SerializationInfo serializationInfo2 = this.a(type);
						base.a(obj, typeof(OnDeserializingAttribute));
						methodBase.Invoke(obj, new object[]
						{
							serializationInfo2,
							this.b
						});
						base.a(obj, typeof(OnDeserializedAttribute));
					}
					else
					{
						obj = FormatterServices.GetUninitializedObject(type);
						if (num != -1)
						{
							this.a(num, obj);
						}
						base.a(obj, typeof(OnDeserializingAttribute));
						int num3 = this.k();
						Dictionary<string, object> dictionary = new Dictionary<string, object>(num3);
						for (int j = 0; j < num3; j++)
						{
							string key = this.s();
							object value = this.c();
							dictionary[key] = value;
						}
						MemberInfo[] array4 = base.g(type);
						object[] array5 = new object[array4.Length];
						for (int k = 0; k < array4.Length; k++)
						{
							MemberInfo memberInfo = array4[k];
							object obj3;
							if (dictionary.TryGetValue(memberInfo.Name, out obj3))
							{
								array5[k] = obj3;
							}
							else if (!this.a(memberInfo))
							{
								throw new SerializationException(string.Format("The stream does not contain a value for field name '{0}'.", memberInfo.Name));
							}
						}
						FormatterServices.PopulateObjectMembers(obj, array4, array5);
						base.a(obj, typeof(OnDeserializedAttribute));
					}
					IDeserializationCallback deserializationCallback = obj as IDeserializationCallback;
					if (deserializationCallback != null)
					{
						this.a.Add(deserializationCallback);
					}
				}
			}
			return obj;
		}
		case r8.f:
		{
			int num = this.k();
			if (num >= this.c.Count)
			{
				throw new SerializationException("A reference to an object ID has been encountered which has not been defined.");
			}
			object obj = this.c[num];
			if (this.a(num))
			{
				return null;
			}
			IObjectReference objectReference2 = obj as IObjectReference;
			if (objectReference2 != null)
			{
				obj = objectReference2.GetRealObject(this.b);
			}
			return obj;
		}
		}
		throw new SerializationException(string.Format("Unexpected element in deserialization stream: {0}", r));
	}

	// Token: 0x06000331 RID: 817 RVA: 0x0000EB4C File Offset: 0x0000CD4C
	private new bool a(MemberInfo A_0)
	{
		bool flag;
		if (!this.g.TryGetValue(A_0, out flag))
		{
			flag = (A_0.GetCustomAttributes(typeof(OptionalFieldAttribute), false).Length != 0);
			this.g[A_0] = flag;
		}
		return flag;
	}

	// Token: 0x06000332 RID: 818 RVA: 0x0000EB90 File Offset: 0x0000CD90
	private new ConstructorInfo d(Type A_0)
	{
		ConstructorInfo constructor;
		if (!this.e.TryGetValue(A_0, out constructor))
		{
			constructor = A_0.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
			{
				typeof(SerializationInfo),
				typeof(StreamingContext)
			}, null);
			if (constructor == null)
			{
				throw new SerializationException(string.Format("The type '{0}' implementing ISerializable doesn't contain a serialization constructor with parameters SerializationInfo, StreamingContext.", A_0.FullName));
			}
			this.e[A_0] = constructor;
		}
		return constructor;
	}

	// Token: 0x06000333 RID: 819 RVA: 0x0000EC0C File Offset: 0x0000CE0C
	private new IObjectReference a(Type A_0, SerializationInfo A_1)
	{
		if (typeof(IObjectReference).IsAssignableFrom(A_0))
		{
			throw new SerializationException(string.Format("The type '{0}' is not an IObjectReference implementation.", A_0.FullName));
		}
		if (typeof(ISerializable).IsAssignableFrom(A_0))
		{
			return (IObjectReference)this.d(A_0).Invoke(new object[]
			{
				A_1,
				this.b
			});
		}
		return (IObjectReference)this.b(A_0);
	}

	// Token: 0x06000334 RID: 820 RVA: 0x0000EC90 File Offset: 0x0000CE90
	private new ConstructorInfo c(Type A_0)
	{
		ConstructorInfo constructor;
		if (!this.f.TryGetValue(A_0, out constructor))
		{
			constructor = A_0.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Type.EmptyTypes, null);
			if (constructor == null)
			{
				throw new SerializationException(string.Format("The type '{0}' does not offer a default constructor.", A_0.FullName));
			}
			this.f[A_0] = constructor;
		}
		return constructor;
	}

	// Token: 0x06000335 RID: 821 RVA: 0x0000ECF0 File Offset: 0x0000CEF0
	private new object b(Type A_0)
	{
		return this.c(A_0).Invoke(this.f);
	}

	// Token: 0x06000336 RID: 822 RVA: 0x0000ED04 File Offset: 0x0000CF04
	private new SerializationInfo a(Type A_0)
	{
		SerializationInfo serializationInfo = new SerializationInfo(A_0, this.e);
		int num = this.k();
		for (int i = 0; i < num; i++)
		{
			string name = this.s();
			object obj = this.c();
			Type type = (obj != null) ? obj.GetType() : typeof(object);
			serializationInfo.AddValue(name, obj, type);
		}
		return serializationInfo;
	}

	// Token: 0x06000337 RID: 823 RVA: 0x0000ED70 File Offset: 0x0000CF70
	private new void a(int A_0, object A_1)
	{
		cf3.AccommodateList<object>(this.c, A_0);
		this.c[A_0] = A_1;
	}

	// Token: 0x06000338 RID: 824 RVA: 0x0000ED90 File Offset: 0x0000CF90
	private new Type b()
	{
		r8 r = (r8)this.q();
		int num = this.k();
		Type result;
		try
		{
			if (r != r8.b)
			{
				if (r != r8.c)
				{
					throw new SerializationException("The stream is not properly structured. Expecting Type or TypeRef");
				}
				result = this.b[num];
			}
			else
			{
				cf3.AccommodateList<Type>(this.b, num);
				string text = this.s();
				string text2 = this.s();
				Type type = this.a.BindToType(text, text2);
				base.e(type);
				this.b[num] = type;
				result = type;
			}
		}
		catch (IndexOutOfRangeException innerException)
		{
			throw new SerializationException("A reference to a type ID appeared before the type was defined.", innerException);
		}
		return result;
	}

	// Token: 0x06000339 RID: 825 RVA: 0x0000EE40 File Offset: 0x0000D040
	private new void a(byte[] A_0, int A_1, int A_2)
	{
		if (this.d.Read(A_0, A_1, A_2) != A_2)
		{
			throw new EndOfStreamException("The stream ended prematurely.");
		}
	}

	// Token: 0x0600033A RID: 826 RVA: 0x0000EE64 File Offset: 0x0000D064
	private new byte a()
	{
		int num = this.d.ReadByte();
		if (num == -1)
		{
			throw new EndOfStreamException("The stream ended prematurely.");
		}
		return (byte)num;
	}

	// Token: 0x0600033B RID: 827 RVA: 0x0000EE84 File Offset: 0x0000D084
	private new void b(int A_0)
	{
		this.d.Add(A_0);
	}

	// Token: 0x0600033C RID: 828 RVA: 0x0000EE94 File Offset: 0x0000D094
	private new bool a(int A_0)
	{
		return this.d.Remove(A_0);
	}

	// Token: 0x0600033D RID: 829 RVA: 0x0000EEA4 File Offset: 0x0000D0A4
	[CompilerGenerated]
	private new void a(Array A_0, int[] A_1)
	{
		A_0.SetValue(this.c(), A_1);
	}

	// Token: 0x040003EB RID: 1003
	private new List<IDeserializationCallback> a;

	// Token: 0x040003EC RID: 1004
	private new List<Type> b;

	// Token: 0x040003ED RID: 1005
	private new List<object> c;

	// Token: 0x040003EE RID: 1006
	private new ISet<int> d;

	// Token: 0x040003EF RID: 1007
	private new Dictionary<Type, ConstructorInfo> e;

	// Token: 0x040003F0 RID: 1008
	private new Dictionary<Type, ConstructorInfo> f;

	// Token: 0x040003F1 RID: 1009
	private new Dictionary<MemberInfo, bool> g;

	// Token: 0x040003F2 RID: 1010
	private List<string> h;
}
