using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001C0E RID: 7182
[TypeConverter(typeof(bf7))]
[eiz("DR")]
[Serializable]
public struct a1q : ISerializable
{
	// Token: 0x17000292 RID: 658
	// (get) Token: 0x06009D93 RID: 40339 RVA: 0x003DEB6C File Offset: 0x003DCD6C
	// (set) Token: 0x06009D94 RID: 40340 RVA: 0x003DEB74 File Offset: 0x003DCD74
	public DamageType DamageType
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x17000293 RID: 659
	// (get) Token: 0x06009D95 RID: 40341 RVA: 0x003DEB80 File Offset: 0x003DCD80
	// (set) Token: 0x06009D96 RID: 40342 RVA: 0x003DEB88 File Offset: 0x003DCD88
	public int LowerBoundary
	{
		get
		{
			return this.b;
		}
		set
		{
			this.b = value;
		}
	}

	// Token: 0x17000294 RID: 660
	// (get) Token: 0x06009D97 RID: 40343 RVA: 0x003DEB94 File Offset: 0x003DCD94
	// (set) Token: 0x06009D98 RID: 40344 RVA: 0x003DEB9C File Offset: 0x003DCD9C
	public int UpperBoundary
	{
		get
		{
			return this.c;
		}
		set
		{
			this.c = value;
		}
	}

	// Token: 0x06009D99 RID: 40345 RVA: 0x003DEBA8 File Offset: 0x003DCDA8
	public static a1q a(a1q A_0, double A_1)
	{
		return new a1q(A_0.DamageType, Convert.ToInt32((double)A_0.LowerBoundary * A_1), Convert.ToInt32((double)A_0.UpperBoundary * A_1));
	}

	// Token: 0x06009D9A RID: 40346 RVA: 0x003DEBE0 File Offset: 0x003DCDE0
	public static bool b(a1q A_0, a1q A_1)
	{
		return A_0.Equals(A_1);
	}

	// Token: 0x06009D9B RID: 40347 RVA: 0x003DEBF8 File Offset: 0x003DCDF8
	public static bool a(a1q A_0, a1q A_1)
	{
		return !A_0.Equals(A_1);
	}

	// Token: 0x06009D9C RID: 40348 RVA: 0x003DEC10 File Offset: 0x003DCE10
	public a1q(DamageType A_0, int A_1, int A_2)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
	}

	// Token: 0x06009D9D RID: 40349 RVA: 0x003DEC28 File Offset: 0x003DCE28
	public override string ToString()
	{
		return this.a(false);
	}

	// Token: 0x06009D9E RID: 40350 RVA: 0x003DEC34 File Offset: 0x003DCE34
	public string a(bool A_0)
	{
		return string.Format("{0}-{1} {2}", this.b, this.c, A_0 ? dh9.a(this.a).ToLowerInvariant() : dh9.a(this.a));
	}

	// Token: 0x06009D9F RID: 40351 RVA: 0x003DEC94 File Offset: 0x003DCE94
	public override bool Equals(object obj)
	{
		if (obj is a1q)
		{
			a1q a1q = (a1q)obj;
			return this.a == a1q.a && this.b == a1q.b && this.c == a1q.c;
		}
		return false;
	}

	// Token: 0x06009DA0 RID: 40352 RVA: 0x003DECE8 File Offset: 0x003DCEE8
	public override int GetHashCode()
	{
		return this.a.GetHashCode() + this.b.GetHashCode() + this.c.GetHashCode();
	}

	// Token: 0x06009DA1 RID: 40353 RVA: 0x003DED18 File Offset: 0x003DCF18
	public static a1q a(string A_0)
	{
		a1q result;
		try
		{
			string[] array = A_0.Split(new char[]
			{
				' '
			});
			string[] array2 = array[0].Split(new char[]
			{
				'-'
			});
			result = new a1q((DamageType)Enum.Parse(typeof(DamageType), array[1]), int.Parse(array2[0]), int.Parse(array2[1]));
		}
		catch
		{
			result = default(a1q);
		}
		return result;
	}

	// Token: 0x06009DA2 RID: 40354 RVA: 0x003DEDB0 File Offset: 0x003DCFB0
	private a1q(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() >= 3)
		{
			this.b = A_0.GetInt32("L");
			this.c = A_0.GetInt32("U");
			this.a = (DamageType)A_0.GetValue("T", typeof(DamageType));
			return;
		}
		this.b = A_0.GetInt32("_LowerBoundary");
		this.c = A_0.GetInt32("_UpperBoundary");
		this.a = (DamageType)A_0.GetValue("_DamageType", typeof(DamageType));
	}

	// Token: 0x06009DA3 RID: 40355 RVA: 0x003DEE50 File Offset: 0x003DD050
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("L", this.b);
		info.AddValue("U", this.c);
		info.AddValue("T", this.a);
	}

	// Token: 0x04003CF1 RID: 15601
	private DamageType a;

	// Token: 0x04003CF2 RID: 15602
	private int b;

	// Token: 0x04003CF3 RID: 15603
	private int c;
}
