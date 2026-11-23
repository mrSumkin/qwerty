using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Vehicles;

// Token: 0x020018EC RID: 6380
[eiz("VHCP")]
[Serializable]
public sealed class c38 : ISerializable
{
	// Token: 0x0600876E RID: 34670 RVA: 0x0037FB50 File Offset: 0x0037DD50
	private c38(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() >= 424)
		{
			this.a = A_0.GetString("VHCP:C");
			this.b = A_0.GetString("VHCP:N");
			this.c = A_0.GetString("VHCP:D");
			this.d = (VehiclePartType)A_0.GetValue("VHCP:T", typeof(VehiclePartType));
			this.e = A_0.GetInt32("VHCP:S");
			this.f = A_0.GetBoolean("VHCP:O");
			if (ell.a() >= 373)
			{
				this.g = (Point)A_0.GetValue("VHCP:P", typeof(Point));
			}
			if (ell.a() >= 412)
			{
				this.h = A_0.GetBoolean("VHCP:L");
				return;
			}
		}
		else
		{
			this.a = A_0.GetString("_Code");
			this.b = A_0.GetString("_Name");
			this.c = A_0.GetString("_Description");
			this.d = (VehiclePartType)A_0.GetValue("_PartType", typeof(VehiclePartType));
			this.e = A_0.GetInt32("_MaxSize");
			this.f = A_0.GetBoolean("_Optional");
			try
			{
				this.g = (Point)A_0.GetValue("_SchematicPosition", typeof(Point));
			}
			catch
			{
			}
			try
			{
				this.h = A_0.GetBoolean("_LivePlacement");
			}
			catch
			{
			}
		}
	}

	// Token: 0x0600876F RID: 34671 RVA: 0x0037FD10 File Offset: 0x0037DF10
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("VHCP:C", this.a);
		info.AddValue("VHCP:N", this.b);
		info.AddValue("VHCP:D", this.c);
		info.AddValue("VHCP:T", this.d);
		info.AddValue("VHCP:S", this.e);
		info.AddValue("VHCP:O", this.f);
		info.AddValue("VHCP:P", this.g);
		info.AddValue("VHCP:L", this.h);
	}

	// Token: 0x06008770 RID: 34672 RVA: 0x0037FDB0 File Offset: 0x0037DFB0
	public string h()
	{
		return this.a;
	}

	// Token: 0x06008771 RID: 34673 RVA: 0x0037FDB8 File Offset: 0x0037DFB8
	public void b(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008772 RID: 34674 RVA: 0x0037FDC4 File Offset: 0x0037DFC4
	public string f()
	{
		return this.b;
	}

	// Token: 0x06008773 RID: 34675 RVA: 0x0037FDCC File Offset: 0x0037DFCC
	public void c(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06008774 RID: 34676 RVA: 0x0037FDD8 File Offset: 0x0037DFD8
	public string e()
	{
		return this.c;
	}

	// Token: 0x06008775 RID: 34677 RVA: 0x0037FDE0 File Offset: 0x0037DFE0
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06008776 RID: 34678 RVA: 0x0037FDEC File Offset: 0x0037DFEC
	public VehiclePartType c()
	{
		return this.d;
	}

	// Token: 0x06008777 RID: 34679 RVA: 0x0037FDF4 File Offset: 0x0037DFF4
	public void a(VehiclePartType A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06008778 RID: 34680 RVA: 0x0037FE00 File Offset: 0x0037E000
	public int a()
	{
		return this.e;
	}

	// Token: 0x06008779 RID: 34681 RVA: 0x0037FE08 File Offset: 0x0037E008
	public void a(int A_0)
	{
		this.e = A_0;
	}

	// Token: 0x0600877A RID: 34682 RVA: 0x0037FE14 File Offset: 0x0037E014
	public bool g()
	{
		return this.f;
	}

	// Token: 0x0600877B RID: 34683 RVA: 0x0037FE1C File Offset: 0x0037E01C
	public void b(bool A_0)
	{
		this.f = A_0;
	}

	// Token: 0x0600877C RID: 34684 RVA: 0x0037FE28 File Offset: 0x0037E028
	public Point d()
	{
		return this.g;
	}

	// Token: 0x0600877D RID: 34685 RVA: 0x0037FE30 File Offset: 0x0037E030
	public void a(Point A_0)
	{
		this.g = A_0;
	}

	// Token: 0x0600877E RID: 34686 RVA: 0x0037FE3C File Offset: 0x0037E03C
	public bool b()
	{
		return this.h;
	}

	// Token: 0x0600877F RID: 34687 RVA: 0x0037FE44 File Offset: 0x0037E044
	public void a(bool A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06008780 RID: 34688 RVA: 0x0037FE50 File Offset: 0x0037E050
	public c38()
	{
	}

	// Token: 0x06008781 RID: 34689 RVA: 0x0037FE58 File Offset: 0x0037E058
	public override string ToString()
	{
		return string.Format("\"{0}\" : {1}", this.a, this.d.ToString());
	}

	// Token: 0x040034C0 RID: 13504
	private string a;

	// Token: 0x040034C1 RID: 13505
	private string b;

	// Token: 0x040034C2 RID: 13506
	private string c;

	// Token: 0x040034C3 RID: 13507
	private VehiclePartType d;

	// Token: 0x040034C4 RID: 13508
	private int e;

	// Token: 0x040034C5 RID: 13509
	private bool f;

	// Token: 0x040034C6 RID: 13510
	private Point g;

	// Token: 0x040034C7 RID: 13511
	private bool h;
}
