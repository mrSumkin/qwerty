using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x020018D0 RID: 6352
[eiz("FV")]
[Serializable]
public sealed class exw : ISerializable
{
	// Token: 0x060086BA RID: 34490 RVA: 0x0037CE74 File Offset: 0x0037B074
	private exw(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (d6n)A_0.GetValue("FV:M", typeof(d6n));
		this.b = A_0.GetDouble("FV:N");
		if (ell.a() >= 298)
		{
			this.c = A_0.GetBoolean("FV:C");
		}
		if (ell.a() >= 599)
		{
			this.d = (A_0.GetValue("FV:V", typeof(float?)) as float?);
		}
	}

	// Token: 0x060086BB RID: 34491 RVA: 0x0037CF0C File Offset: 0x0037B10C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("FV:M", this.a);
		info.AddValue("FV:N", this.b);
		info.AddValue("FV:C", this.c);
		info.AddValue("FV:V", this.d);
	}

	// Token: 0x060086BC RID: 34492 RVA: 0x0037CF68 File Offset: 0x0037B168
	public void a(BinaryWriter A_0)
	{
		A_0.Write((int)this.a);
		A_0.Write(this.b);
		A_0.Write(this.c);
		A_0.Write(this.d != null);
		if (this.d != null)
		{
			A_0.Write(this.d.Value);
		}
	}

	// Token: 0x060086BD RID: 34493 RVA: 0x0037CFCC File Offset: 0x0037B1CC
	public static exw a(BinaryReader A_0)
	{
		exw exw = new exw();
		exw.a = (d6n)A_0.ReadInt32();
		exw.b = A_0.ReadDouble();
		exw.c = A_0.ReadBoolean();
		if (A_0.ReadBoolean())
		{
			exw.d = new float?(A_0.ReadSingle());
		}
		return exw;
	}

	// Token: 0x060086BE RID: 34494 RVA: 0x0037D020 File Offset: 0x0037B220
	public d6n c()
	{
		return this.a;
	}

	// Token: 0x060086BF RID: 34495 RVA: 0x0037D028 File Offset: 0x0037B228
	public void a(d6n A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060086C0 RID: 34496 RVA: 0x0037D034 File Offset: 0x0037B234
	public double b()
	{
		return this.b;
	}

	// Token: 0x060086C1 RID: 34497 RVA: 0x0037D03C File Offset: 0x0037B23C
	public void a(double A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060086C2 RID: 34498 RVA: 0x0037D048 File Offset: 0x0037B248
	public bool a()
	{
		return this.c;
	}

	// Token: 0x060086C3 RID: 34499 RVA: 0x0037D050 File Offset: 0x0037B250
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060086C4 RID: 34500 RVA: 0x0037D05C File Offset: 0x0037B25C
	public float? d()
	{
		return this.d;
	}

	// Token: 0x060086C5 RID: 34501 RVA: 0x0037D064 File Offset: 0x0037B264
	public void a(float? A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060086C6 RID: 34502 RVA: 0x0037D070 File Offset: 0x0037B270
	public exw()
	{
	}

	// Token: 0x060086C7 RID: 34503 RVA: 0x0037D078 File Offset: 0x0037B278
	public exw(d6n A_0, double A_1 = 0.0, bool A_2 = false, float? A_3 = null)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
		this.d = A_3;
	}

	// Token: 0x040033F4 RID: 13300
	private d6n a;

	// Token: 0x040033F5 RID: 13301
	private double b;

	// Token: 0x040033F6 RID: 13302
	private bool c;

	// Token: 0x040033F7 RID: 13303
	private float? d;
}
