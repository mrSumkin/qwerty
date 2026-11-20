using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020010E0 RID: 4320
[eiz("SGV2")]
[Serializable]
public sealed class an6 : cze, ISerializable
{
	// Token: 0x06005B18 RID: 23320 RVA: 0x00273208 File Offset: 0x00271408
	private an6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("SGV2:V");
		di7.ReadList<string>("SGV2:E", ref this.b, A_0);
		this.c = A_0.GetSingle("SGV2:A");
		if (ell.a() >= 528)
		{
			this.d = A_0.GetString("SGV2:R");
		}
	}

	// Token: 0x06005B19 RID: 23321 RVA: 0x0027327C File Offset: 0x0027147C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SGV2:V", this.a);
		di7.WriteList<string>("SGV2:E", this.b, info);
		info.AddValue("SGV2:A", this.c);
		info.AddValue("SGV2:R", this.d);
	}

	// Token: 0x06005B1A RID: 23322 RVA: 0x002732D8 File Offset: 0x002714D8
	public bool c()
	{
		return this.a;
	}

	// Token: 0x06005B1B RID: 23323 RVA: 0x002732E0 File Offset: 0x002714E0
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005B1C RID: 23324 RVA: 0x002732EC File Offset: 0x002714EC
	public float d()
	{
		return this.c;
	}

	// Token: 0x06005B1D RID: 23325 RVA: 0x002732F4 File Offset: 0x002714F4
	public void a(float A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005B1E RID: 23326 RVA: 0x00273300 File Offset: 0x00271500
	public List<string> a()
	{
		return this.b;
	}

	// Token: 0x06005B1F RID: 23327 RVA: 0x00273308 File Offset: 0x00271508
	public void a(List<string> A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005B20 RID: 23328 RVA: 0x00273314 File Offset: 0x00271514
	public string b()
	{
		return this.d;
	}

	// Token: 0x06005B21 RID: 23329 RVA: 0x0027331C File Offset: 0x0027151C
	public void a(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005B22 RID: 23330 RVA: 0x00273328 File Offset: 0x00271528
	public an6()
	{
	}

	// Token: 0x06005B23 RID: 23331 RVA: 0x0027333C File Offset: 0x0027153C
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
		if (aud != null)
		{
			List<c5x> list = new List<c5x>();
			if (this.b.Count > 0)
			{
				foreach (string g in this.b)
				{
					c5x c5x = new ar7(new Guid(g), aud).ao() as c5x;
					if (c5x != null)
					{
						list.Add(c5x);
					}
				}
			}
			if (!string.IsNullOrWhiteSpace(this.d) && aud.Zone != null)
			{
				d60 d = aud.Zone.a();
				if (d != null)
				{
					List<b0b> list2 = d.ab4(new string[]
					{
						this.d
					});
					list.AddRange(Enumerable.OfType<c5x>(list2));
				}
			}
			foreach (c5x c5x2 in list)
			{
				if (c5x2 != null)
				{
					c5x2.ae = new float?(this.a ? 1f : this.c);
				}
			}
		}
	}

	// Token: 0x04002467 RID: 9319
	private new bool a;

	// Token: 0x04002468 RID: 9320
	private List<string> b = new List<string>();

	// Token: 0x04002469 RID: 9321
	private float c;

	// Token: 0x0400246A RID: 9322
	private string d;
}
