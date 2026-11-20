using System;
using System.Runtime.Serialization;

// Token: 0x0200022F RID: 559
[eiz("PS1")]
[Serializable]
public struct d4p : ISerializable
{
	// Token: 0x06000F8D RID: 3981 RVA: 0x00040A3C File Offset: 0x0003EC3C
	public d4p(bool A_0)
	{
		this = default(d4p);
		if (A_0)
		{
			this.e = new agq(1U);
			this.f = new agq(1U);
			this.g = new agq(3U);
			this.h = d4p.b;
			this.i = 0.1f;
			this.j = 0.3f;
		}
	}

	// Token: 0x06000F8E RID: 3982 RVA: 0x00040A9C File Offset: 0x0003EC9C
	public agq b()
	{
		return this.e;
	}

	// Token: 0x06000F8F RID: 3983 RVA: 0x00040AA4 File Offset: 0x0003ECA4
	public void a(agq A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06000F90 RID: 3984 RVA: 0x00040AB0 File Offset: 0x0003ECB0
	public agq d()
	{
		return this.f;
	}

	// Token: 0x06000F91 RID: 3985 RVA: 0x00040AB8 File Offset: 0x0003ECB8
	public void c(agq A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06000F92 RID: 3986 RVA: 0x00040AC4 File Offset: 0x0003ECC4
	public agq f()
	{
		return this.g;
	}

	// Token: 0x06000F93 RID: 3987 RVA: 0x00040ACC File Offset: 0x0003ECCC
	public void b(agq A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06000F94 RID: 3988 RVA: 0x00040AD8 File Offset: 0x0003ECD8
	public TimeSpan c()
	{
		return this.h;
	}

	// Token: 0x06000F95 RID: 3989 RVA: 0x00040AE0 File Offset: 0x0003ECE0
	public void a(TimeSpan A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06000F96 RID: 3990 RVA: 0x00040AEC File Offset: 0x0003ECEC
	public float a()
	{
		return this.i;
	}

	// Token: 0x06000F97 RID: 3991 RVA: 0x00040AF4 File Offset: 0x0003ECF4
	public void b(float A_0)
	{
		this.i = A_0;
	}

	// Token: 0x06000F98 RID: 3992 RVA: 0x00040B00 File Offset: 0x0003ED00
	public float e()
	{
		return this.j;
	}

	// Token: 0x06000F99 RID: 3993 RVA: 0x00040B08 File Offset: 0x0003ED08
	public void a(float A_0)
	{
		this.j = A_0;
	}

	// Token: 0x06000F9A RID: 3994 RVA: 0x00040B14 File Offset: 0x0003ED14
	private d4p(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() >= 6)
		{
			this.i = A_0.GetSingle("MIMS");
			this.j = A_0.GetSingle("MXMS");
			this.h = (TimeSpan)A_0.GetValue("DMT", typeof(TimeSpan));
			this.e = (agq)A_0.GetValue("SP", typeof(agq));
			this.f = (agq)A_0.GetValue("LP", typeof(agq));
			this.g = (agq)A_0.GetValue("PP", typeof(agq));
			return;
		}
		this.i = A_0.GetSingle("_MinimalMovementStep");
		this.j = A_0.GetSingle("_MaximalMovementStep");
		this.h = (TimeSpan)A_0.GetValue("_DefaultMovementTick", typeof(TimeSpan));
		this.e = (agq)A_0.GetValue("_SightProcessing", typeof(agq));
		this.f = (agq)A_0.GetValue("_LightProcessing", typeof(agq));
		this.g = (agq)A_0.GetValue("_PathProcessing", typeof(agq));
	}

	// Token: 0x06000F9B RID: 3995 RVA: 0x00040C74 File Offset: 0x0003EE74
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("MIMS", this.i);
		info.AddValue("MXMS", this.j);
		info.AddValue("DMT", this.h);
		info.AddValue("SP", this.e);
		info.AddValue("LP", this.f);
		info.AddValue("PP", this.g);
	}

	// Token: 0x04000937 RID: 2359
	private const uint a = 1U;

	// Token: 0x04000938 RID: 2360
	public static readonly TimeSpan b = TimeSpan.FromMilliseconds(50.0);

	// Token: 0x04000939 RID: 2361
	public const float c = 0.1f;

	// Token: 0x0400093A RID: 2362
	public const float d = 0.3f;

	// Token: 0x0400093B RID: 2363
	private agq e;

	// Token: 0x0400093C RID: 2364
	private agq f;

	// Token: 0x0400093D RID: 2365
	private agq g;

	// Token: 0x0400093E RID: 2366
	private TimeSpan h;

	// Token: 0x0400093F RID: 2367
	private float i;

	// Token: 0x04000940 RID: 2368
	private float j;
}
