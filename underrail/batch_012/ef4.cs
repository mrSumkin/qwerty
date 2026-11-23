using System;
using System.Runtime.Serialization;

// Token: 0x02000080 RID: 128
[eiz("ZSK")]
[Serializable]
public struct ef4 : ISerializable
{
	// Token: 0x060002EC RID: 748 RVA: 0x0000D954 File Offset: 0x0000BB54
	public Guid b()
	{
		return this.b;
	}

	// Token: 0x060002ED RID: 749 RVA: 0x0000D95C File Offset: 0x0000BB5C
	public string c()
	{
		return this.c;
	}

	// Token: 0x060002EE RID: 750 RVA: 0x0000D964 File Offset: 0x0000BB64
	public static ef4 a()
	{
		return ef4.a;
	}

	// Token: 0x060002EF RID: 751 RVA: 0x0000D96C File Offset: 0x0000BB6C
	public static bool b(ef4 A_0, ef4 A_1)
	{
		return A_0.Equals(A_1);
	}

	// Token: 0x060002F0 RID: 752 RVA: 0x0000D984 File Offset: 0x0000BB84
	public static bool a(ef4 A_0, ef4 A_1)
	{
		return !A_0.Equals(A_1);
	}

	// Token: 0x060002F1 RID: 753 RVA: 0x0000D99C File Offset: 0x0000BB9C
	public ef4(Guid A_0, string A_1)
	{
		this.b = A_0;
		this.c = A_1;
	}

	// Token: 0x060002F2 RID: 754 RVA: 0x0000D9B0 File Offset: 0x0000BBB0
	public override string ToString()
	{
		Guid guid = this.b;
		return guid.ToString() + ":" + this.c;
	}

	// Token: 0x060002F3 RID: 755 RVA: 0x0000D9E4 File Offset: 0x0000BBE4
	public override bool Equals(object obj)
	{
		if (!(obj is ef4))
		{
			return false;
		}
		ef4 ef = (ef4)obj;
		return ef.b == this.b && ef.c == this.c;
	}

	// Token: 0x060002F4 RID: 756 RVA: 0x0000DA30 File Offset: 0x0000BC30
	public override int GetHashCode()
	{
		return this.b.GetHashCode() + ((this.c != null) ? this.c.GetHashCode() : 0);
	}

	// Token: 0x060002F5 RID: 757 RVA: 0x0000DA60 File Offset: 0x0000BC60
	public static ef4 a(b0b A_0, string A_1)
	{
		if (A_0 == null || A_0.Area == null)
		{
			return new ef4(Guid.Empty, A_1);
		}
		return new ef4(A_0.Area.qe(), A_1);
	}

	// Token: 0x060002F6 RID: 758 RVA: 0x0000DA94 File Offset: 0x0000BC94
	private ef4(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() >= 6)
		{
			this.c = A_0.GetString("I");
			this.b = (Guid)A_0.GetValue("A", typeof(Guid));
			return;
		}
		this.c = A_0.GetString("_InstanceId");
		this.b = (Guid)A_0.GetValue("_AreaId", typeof(Guid));
	}

	// Token: 0x060002F7 RID: 759 RVA: 0x0000DB10 File Offset: 0x0000BD10
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("I", this.c);
		info.AddValue("A", this.b);
	}

	// Token: 0x040003D7 RID: 983
	private static ef4 a;

	// Token: 0x040003D8 RID: 984
	private Guid b;

	// Token: 0x040003D9 RID: 985
	private string c;
}
