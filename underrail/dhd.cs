using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001065 RID: 4197
[eiz("SGV")]
[Serializable]
public sealed class dhd : cze, ISerializable
{
	// Token: 0x06005737 RID: 22327 RVA: 0x0026204C File Offset: 0x0026024C
	private dhd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("SGV:V");
		di7.ReadList<string>("SGV:E", ref this.b, A_0);
		if (ell.a() >= 363)
		{
			this.c = A_0.GetSingle("SGV:A");
		}
	}

	// Token: 0x06005738 RID: 22328 RVA: 0x002620B0 File Offset: 0x002602B0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SGV:V", this.a);
		di7.WriteList<string>("SGV:E", this.b, info);
		info.AddValue("SGV:A", this.c);
	}

	// Token: 0x06005739 RID: 22329 RVA: 0x002620F0 File Offset: 0x002602F0
	public bool b()
	{
		return this.a;
	}

	// Token: 0x0600573A RID: 22330 RVA: 0x002620F8 File Offset: 0x002602F8
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600573B RID: 22331 RVA: 0x00262104 File Offset: 0x00260304
	public float c()
	{
		return this.c;
	}

	// Token: 0x0600573C RID: 22332 RVA: 0x0026210C File Offset: 0x0026030C
	public void a(float A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600573D RID: 22333 RVA: 0x00262118 File Offset: 0x00260318
	public List<string> a()
	{
		return this.b;
	}

	// Token: 0x0600573E RID: 22334 RVA: 0x00262120 File Offset: 0x00260320
	public void a(List<string> A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600573F RID: 22335 RVA: 0x0026212C File Offset: 0x0026032C
	private dhd()
	{
	}

	// Token: 0x06005740 RID: 22336 RVA: 0x00262144 File Offset: 0x00260344
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (A_2 != null && A_2.ContainsKey("area"))
		{
			aud = (A_2["area"] as aud);
		}
		if (aud == null && A_0 != null)
		{
			aud = A_0.Area;
		}
		if (aud != null && this.b.Count > 0)
		{
			foreach (string g in this.b)
			{
				c5x c5x = new ar7(new Guid(g), aud).ao() as c5x;
				if (c5x != null)
				{
					if (c5x.o.b != null)
					{
						c5x.o.b.d = new float?(this.a ? 1f : this.c);
					}
					else if (c5x.p.b != null)
					{
						foreach (cd0 cd in c5x.p.b.a)
						{
							cd.c = null;
							cd.d = new float?(this.a ? 1f : this.c);
						}
					}
				}
			}
		}
	}

	// Token: 0x04002350 RID: 9040
	private new bool a;

	// Token: 0x04002351 RID: 9041
	private List<string> b = new List<string>();

	// Token: 0x04002352 RID: 9042
	private float c;
}
