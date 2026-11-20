using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001062 RID: 4194
[eiz("RTSSJ")]
[Serializable]
public sealed class b7n : cze, ISerializable
{
	// Token: 0x06005719 RID: 22297 RVA: 0x00261BB4 File Offset: 0x0025FDB4
	private b7n(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Point)A_0.GetValue("RTSSJ:S", typeof(Point));
		this.b = (Point)A_0.GetValue("RTSSJ:D", typeof(Point));
		this.c = A_0.GetInt32("RTSSJ:E");
		this.d = A_0.GetString("RTSSJ:A");
	}

	// Token: 0x0600571A RID: 22298 RVA: 0x00261C2C File Offset: 0x0025FE2C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("RTSSJ:S", this.a);
		info.AddValue("RTSSJ:D", this.b);
		info.AddValue("RTSSJ:E", this.c);
		info.AddValue("RTSSJ:A", this.d);
	}

	// Token: 0x0600571B RID: 22299 RVA: 0x00261C90 File Offset: 0x0025FE90
	public Point c()
	{
		return this.a;
	}

	// Token: 0x0600571C RID: 22300 RVA: 0x00261C98 File Offset: 0x0025FE98
	public void b(Point A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600571D RID: 22301 RVA: 0x00261CA4 File Offset: 0x0025FEA4
	public Point a()
	{
		return this.b;
	}

	// Token: 0x0600571E RID: 22302 RVA: 0x00261CAC File Offset: 0x0025FEAC
	public void a(Point A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600571F RID: 22303 RVA: 0x00261CB8 File Offset: 0x0025FEB8
	public int b()
	{
		return this.c;
	}

	// Token: 0x06005720 RID: 22304 RVA: 0x00261CC0 File Offset: 0x0025FEC0
	public void a(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005721 RID: 22305 RVA: 0x00261CCC File Offset: 0x0025FECC
	public string d()
	{
		return this.d;
	}

	// Token: 0x06005722 RID: 22306 RVA: 0x00261CD4 File Offset: 0x0025FED4
	public void a(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005723 RID: 22307 RVA: 0x00261CE0 File Offset: 0x0025FEE0
	public b7n()
	{
	}

	// Token: 0x06005724 RID: 22308 RVA: 0x00261CEC File Offset: 0x0025FEEC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (this.d != null)
		{
			b4b serviceOrThrow = bpo.GetServiceOrThrow<b4b>();
			if (serviceOrThrow.yn() != null && serviceOrThrow.yn().Zones.Count > 0)
			{
				aud = serviceOrThrow.yn().Zones[0].n(this.d);
			}
		}
		else if (A_0 != null)
		{
			aud = A_0.Area;
		}
		else if (A_1 != null)
		{
			aud = A_1.Area;
		}
		if (aud != null)
		{
			dt3.a(aud, this.a, this.b, this.c);
		}
	}

	// Token: 0x04002347 RID: 9031
	private new Point a;

	// Token: 0x04002348 RID: 9032
	private Point b;

	// Token: 0x04002349 RID: 9033
	private int c;

	// Token: 0x0400234A RID: 9034
	private string d;
}
