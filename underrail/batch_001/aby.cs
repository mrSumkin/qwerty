using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x0200103B RID: 4155
[eiz("ATJ2")]
[Serializable]
public sealed class aby : cze, ISerializable
{
	// Token: 0x060055D9 RID: 21977 RVA: 0x0025D1AC File Offset: 0x0025B3AC
	private aby(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("ATJ2:R", typeof(e6z)) as e6z);
		this.b = (Vector3)A_0.GetValue("ATJ2:L", typeof(Vector3));
		this.c = (HorizontalDirection?)A_0.GetValue("ATJ2:D", typeof(HorizontalDirection?));
		this.d = A_0.GetBoolean("ATJ2:C");
		this.e = (Guid?)A_0.GetValue("ATJ2:I", typeof(Guid?));
		this.f = A_0.GetString("ATJ2:A");
	}

	// Token: 0x060055DA RID: 21978 RVA: 0x0025D264 File Offset: 0x0025B464
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ATJ2:R", this.a);
		info.AddValue("ATJ2:L", this.b);
		info.AddValue("ATJ2:D", this.c);
		info.AddValue("ATJ2:C", this.d);
		info.AddValue("ATJ2:I", this.e);
		info.AddValue("ATJ2:A", this.f);
	}

	// Token: 0x060055DB RID: 21979 RVA: 0x0025D2F0 File Offset: 0x0025B4F0
	public e6z d()
	{
		return this.a;
	}

	// Token: 0x060055DC RID: 21980 RVA: 0x0025D2F8 File Offset: 0x0025B4F8
	public void a(e6z A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060055DD RID: 21981 RVA: 0x0025D304 File Offset: 0x0025B504
	public Vector3 f()
	{
		return this.b;
	}

	// Token: 0x060055DE RID: 21982 RVA: 0x0025D30C File Offset: 0x0025B50C
	public void a(Vector3 A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060055DF RID: 21983 RVA: 0x0025D318 File Offset: 0x0025B518
	public HorizontalDirection? a()
	{
		return this.c;
	}

	// Token: 0x060055E0 RID: 21984 RVA: 0x0025D320 File Offset: 0x0025B520
	public void a(HorizontalDirection? A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060055E1 RID: 21985 RVA: 0x0025D32C File Offset: 0x0025B52C
	public bool b()
	{
		return this.d;
	}

	// Token: 0x060055E2 RID: 21986 RVA: 0x0025D334 File Offset: 0x0025B534
	public void a(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060055E3 RID: 21987 RVA: 0x0025D340 File Offset: 0x0025B540
	public string c()
	{
		return this.f;
	}

	// Token: 0x060055E4 RID: 21988 RVA: 0x0025D348 File Offset: 0x0025B548
	public void a(string A_0)
	{
		this.f = A_0;
	}

	// Token: 0x060055E5 RID: 21989 RVA: 0x0025D354 File Offset: 0x0025B554
	public Guid? e()
	{
		return this.e;
	}

	// Token: 0x060055E6 RID: 21990 RVA: 0x0025D35C File Offset: 0x0025B55C
	public void a(Guid? A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060055E7 RID: 21991 RVA: 0x0025D368 File Offset: 0x0025B568
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (this.a != null && this.a.ao() != null)
		{
			c5x c5x = null;
			if (this.e != null)
			{
				aud aud = null;
				if (this.f != null)
				{
					b4b serviceOrThrow = bpo.GetServiceOrThrow<b4b>();
					if (serviceOrThrow.yn() != null && serviceOrThrow.yn().Zones.Count > 0)
					{
						aud = serviceOrThrow.yn().Zones[0].n(this.f);
					}
				}
				else if (A_0 != null)
				{
					aud = A_0.Area;
				}
				if (aud != null)
				{
					c5x = (new ar7(this.e.Value, aud).ao() as c5x);
				}
			}
			else
			{
				c5x = (A_0 as c5x);
			}
			if (c5x != null)
			{
				a0l.a(c5x, this.a.ao(), this.b, this.c, this.d);
			}
		}
	}

	// Token: 0x060055E8 RID: 21992 RVA: 0x0025D45C File Offset: 0x0025B65C
	public aby()
	{
	}

	// Token: 0x040022E3 RID: 8931
	private new e6z a;

	// Token: 0x040022E4 RID: 8932
	private Vector3 b;

	// Token: 0x040022E5 RID: 8933
	private HorizontalDirection? c;

	// Token: 0x040022E6 RID: 8934
	private bool d;

	// Token: 0x040022E7 RID: 8935
	private Guid? e;

	// Token: 0x040022E8 RID: 8936
	private string f;
}
