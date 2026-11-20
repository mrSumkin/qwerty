using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000490 RID: 1168
[eiz("IPD")]
[Serializable]
public sealed class d8h : ISerializable
{
	// Token: 0x06001DE4 RID: 7652 RVA: 0x000A5DA0 File Offset: 0x000A3FA0
	private d8h(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("IPD:TN");
			this.b = (Point)A_0.GetValue("IPD:P", typeof(Point));
			this.c = A_0.GetSingle("IPD:A");
			return;
		}
		if (base.GetType() == typeof(d8h))
		{
			this.a = A_0.GetString("_TextureName");
			this.b = (Point)A_0.GetValue("_Position", typeof(Point));
			this.c = A_0.GetSingle("_Alpha");
			return;
		}
		this.a = A_0.GetString("IconPartDescription+_TextureName");
		this.b = (Point)A_0.GetValue("IconPartDescription+_Position", typeof(Point));
		this.c = A_0.GetSingle("IconPartDescription+_Alpha");
	}

	// Token: 0x06001DE5 RID: 7653 RVA: 0x000A5EAC File Offset: 0x000A40AC
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("IPD:TN", this.a);
		info.AddValue("IPD:P", this.b);
		info.AddValue("IPD:A", this.c);
	}

	// Token: 0x06001DE6 RID: 7654 RVA: 0x000A5EE8 File Offset: 0x000A40E8
	public string c()
	{
		return this.a;
	}

	// Token: 0x06001DE7 RID: 7655 RVA: 0x000A5EF0 File Offset: 0x000A40F0
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001DE8 RID: 7656 RVA: 0x000A5EFC File Offset: 0x000A40FC
	public Point a()
	{
		return this.b;
	}

	// Token: 0x06001DE9 RID: 7657 RVA: 0x000A5F04 File Offset: 0x000A4104
	public void a(Point A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06001DEA RID: 7658 RVA: 0x000A5F10 File Offset: 0x000A4110
	public float b()
	{
		return this.c;
	}

	// Token: 0x06001DEB RID: 7659 RVA: 0x000A5F18 File Offset: 0x000A4118
	public void a(float A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06001DEC RID: 7660 RVA: 0x000A5F24 File Offset: 0x000A4124
	public d8h()
	{
	}

	// Token: 0x06001DED RID: 7661 RVA: 0x000A5F38 File Offset: 0x000A4138
	public d8h(string A_0, Point A_1, float A_2 = 1f)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
	}

	// Token: 0x0400128C RID: 4748
	private string a;

	// Token: 0x0400128D RID: 4749
	private Point b;

	// Token: 0x0400128E RID: 4750
	private float c = 1f;
}
