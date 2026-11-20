using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010AE RID: 4270
[eiz("SPEPSJ")]
[Serializable]
public sealed class eon : cze
{
	// Token: 0x060059B4 RID: 22964 RVA: 0x0026BE10 File Offset: 0x0026A010
	private eon(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid?)A_0.GetValue("SPEPSJ:I", typeof(Guid?));
		this.b = A_0.GetString("SPEPSJ:A");
		di7.ReadList<string>("SPEPSJ:S", ref this.c, A_0);
	}

	// Token: 0x060059B5 RID: 22965 RVA: 0x0026BE74 File Offset: 0x0026A074
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SPEPSJ:I", this.a);
		info.AddValue("SPEPSJ:A", this.b);
		di7.WriteList<string>("SPEPSJ:S", this.c, info);
	}

	// Token: 0x060059B6 RID: 22966 RVA: 0x0026BEC4 File Offset: 0x0026A0C4
	public string b()
	{
		return this.b;
	}

	// Token: 0x060059B7 RID: 22967 RVA: 0x0026BECC File Offset: 0x0026A0CC
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060059B8 RID: 22968 RVA: 0x0026BED8 File Offset: 0x0026A0D8
	public Guid? c()
	{
		return this.a;
	}

	// Token: 0x060059B9 RID: 22969 RVA: 0x0026BEE0 File Offset: 0x0026A0E0
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060059BA RID: 22970 RVA: 0x0026BEEC File Offset: 0x0026A0EC
	public List<string> a()
	{
		return this.c;
	}

	// Token: 0x060059BB RID: 22971 RVA: 0x0026BEF4 File Offset: 0x0026A0F4
	public void a(List<string> A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060059BC RID: 22972 RVA: 0x0026BF00 File Offset: 0x0026A100
	public eon()
	{
	}

	// Token: 0x060059BD RID: 22973 RVA: 0x0026BF14 File Offset: 0x0026A114
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (this.a != null)
		{
			aud aud = null;
			if (this.b != null)
			{
				b4b serviceOrThrow = bpo.GetServiceOrThrow<b4b>();
				if (serviceOrThrow.yn() != null && serviceOrThrow.yn().Zones.Count > 0)
				{
					aud = serviceOrThrow.yn().Zones[0].n(this.b);
				}
			}
			else if (A_1 != null)
			{
				aud = A_1.Area;
			}
			if (aud != null)
			{
				c5x = (new ar7(this.a.Value, aud).ao() as c5x);
			}
		}
		else
		{
			c5x = (A_1 as c5x);
		}
		if (c5x != null)
		{
			dt5 aspect = A_1.GetAspect<dt5>();
			if (aspect != null)
			{
				aspect.a(new List<string>(this.c));
				aspect.h();
			}
		}
	}

	// Token: 0x04002406 RID: 9222
	private new Guid? a;

	// Token: 0x04002407 RID: 9223
	private string b;

	// Token: 0x04002408 RID: 9224
	private List<string> c = new List<string>();
}
