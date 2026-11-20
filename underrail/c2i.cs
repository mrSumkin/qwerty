using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001043 RID: 4163
[eiz("SEABRCJ")]
[Serializable]
public sealed class c2i : cze, ISerializable
{
	// Token: 0x06005627 RID: 22055 RVA: 0x0025E37C File Offset: 0x0025C57C
	private c2i(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.c = A_0.GetString("SEABRCJ:R");
		this.b = A_0.GetString("SEABRCJ:A");
		this.a = (A_0.GetValue("SEABRCJ:L", typeof(float?)) as float?);
	}

	// Token: 0x06005628 RID: 22056 RVA: 0x0025E3D8 File Offset: 0x0025C5D8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SEABRCJ:R", this.c);
		info.AddValue("SEABRCJ:A", this.b);
		info.AddValue("SEABRCJ:L", this.a);
	}

	// Token: 0x06005629 RID: 22057 RVA: 0x0025E428 File Offset: 0x0025C628
	public float? c()
	{
		return this.a;
	}

	// Token: 0x0600562A RID: 22058 RVA: 0x0025E430 File Offset: 0x0025C630
	public void a(float? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600562B RID: 22059 RVA: 0x0025E43C File Offset: 0x0025C63C
	public string a()
	{
		return this.b;
	}

	// Token: 0x0600562C RID: 22060 RVA: 0x0025E444 File Offset: 0x0025C644
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600562D RID: 22061 RVA: 0x0025E450 File Offset: 0x0025C650
	public string b()
	{
		return this.c;
	}

	// Token: 0x0600562E RID: 22062 RVA: 0x0025E458 File Offset: 0x0025C658
	public void b(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600562F RID: 22063 RVA: 0x0025E464 File Offset: 0x0025C664
	public c2i()
	{
	}

	// Token: 0x06005630 RID: 22064 RVA: 0x0025E46C File Offset: 0x0025C66C
	public sealed override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (this.c() == null)
		{
			this.a(new float?(0f));
		}
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
		else if (A_0 != null)
		{
			aud = A_0.Area;
		}
		if (this.b() != null && aud != null)
		{
			d60 d = aud.Zone.a();
			if (d != null)
			{
				List<b0b> list = d.ab4(new string[]
				{
					this.b()
				});
				if (list != null)
				{
					foreach (b0b b0b in list)
					{
						((c5x)b0b).ae = this.c();
					}
				}
			}
		}
	}

	// Token: 0x040022FD RID: 8957
	private new float? a;

	// Token: 0x040022FE RID: 8958
	private string b;

	// Token: 0x040022FF RID: 8959
	private string c;
}
