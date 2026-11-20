using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001278 RID: 4728
[a(typeof(ce1))]
[eiz("JTBEA")]
[Serializable]
public sealed class ccm : ce1, ISerializable
{
	// Token: 0x060066A2 RID: 26274 RVA: 0x002B9F48 File Offset: 0x002B8148
	private ccm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<cze>("JTBEA:J", ref this.a, A_0);
		this.b = A_0.GetInt32("JTBEA:M");
		this.c = A_0.GetInt32("JTBEA:E");
	}

	// Token: 0x060066A3 RID: 26275 RVA: 0x002B9FA4 File Offset: 0x002B81A4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<cze>("JTBEA:J", this.a, info);
		info.AddValue("JTBEA:M", this.b);
		info.AddValue("JTBEA:E", this.c);
	}

	// Token: 0x060066A4 RID: 26276 RVA: 0x002B9FE4 File Offset: 0x002B81E4
	public List<cze> a()
	{
		return this.a;
	}

	// Token: 0x060066A5 RID: 26277 RVA: 0x002B9FEC File Offset: 0x002B81EC
	public void a(List<cze> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060066A6 RID: 26278 RVA: 0x002B9FF8 File Offset: 0x002B81F8
	public int b()
	{
		return this.b;
	}

	// Token: 0x060066A7 RID: 26279 RVA: 0x002BA000 File Offset: 0x002B8200
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060066A8 RID: 26280 RVA: 0x002BA00C File Offset: 0x002B820C
	public int d()
	{
		return this.c;
	}

	// Token: 0x060066A9 RID: 26281 RVA: 0x002BA014 File Offset: 0x002B8214
	public ccm(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060066AA RID: 26282 RVA: 0x002BA030 File Offset: 0x002B8230
	public override void n3(int A_0)
	{
		if (this.b <= 0 || this.c < this.b)
		{
			foreach (cze cze in this.a)
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary["execution"] = this.c;
				dictionary["burnLevel"] = A_0;
				cze.ym(base.a8(), base.a8(), dictionary);
			}
			this.c++;
		}
	}

	// Token: 0x04002A96 RID: 10902
	private List<cze> a = new List<cze>();

	// Token: 0x04002A97 RID: 10903
	private int b = 1;

	// Token: 0x04002A98 RID: 10904
	private int c;
}
