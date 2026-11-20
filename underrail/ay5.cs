using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010FB RID: 4347
[eiz("G10")]
[Serializable]
public sealed class ay5 : cze, ISerializable
{
	// Token: 0x06005C25 RID: 23589 RVA: 0x00277498 File Offset: 0x00275698
	private ay5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("G10:QN");
		this.b = A_0.GetBoolean("G10:PE");
		if (ell.a() >= 563)
		{
			this.c = A_0.GetBoolean("G10:AI");
		}
	}

	// Token: 0x06005C26 RID: 23590 RVA: 0x002774F0 File Offset: 0x002756F0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("G10:QN", this.a);
		info.AddValue("G10:PE", this.b);
		info.AddValue("G10:AI", this.c);
	}

	// Token: 0x06005C27 RID: 23591 RVA: 0x00277538 File Offset: 0x00275738
	public string b()
	{
		return this.a;
	}

	// Token: 0x06005C28 RID: 23592 RVA: 0x00277540 File Offset: 0x00275740
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005C29 RID: 23593 RVA: 0x0027754C File Offset: 0x0027574C
	public bool c()
	{
		return this.b;
	}

	// Token: 0x06005C2A RID: 23594 RVA: 0x00277554 File Offset: 0x00275754
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005C2B RID: 23595 RVA: 0x00277560 File Offset: 0x00275760
	public bool a()
	{
		return this.c;
	}

	// Token: 0x06005C2C RID: 23596 RVA: 0x00277568 File Offset: 0x00275768
	public void b(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005C2D RID: 23597 RVA: 0x00277574 File Offset: 0x00275774
	public ay5()
	{
	}

	// Token: 0x06005C2E RID: 23598 RVA: 0x00277580 File Offset: 0x00275780
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (!string.IsNullOrEmpty(this.a))
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
			{
				c3n c3n = dgk.a(this.a);
				if (c3n != null && !serviceOrThrow.aqu().v().PsiAbilities.c(c3n))
				{
					serviceOrThrow.aqu().v().PsiAbilities.b(c3n);
					if (this.b)
					{
						a7v.a(new es8(new ap9(serviceOrThrow.aqu().v()), this.a));
					}
					if (this.c)
					{
						int num = c2h.b(serviceOrThrow.aqu().v());
						int num2 = -1;
						for (int i = 0; i < num; i++)
						{
							if (serviceOrThrow.aqu().v().Offense.ai[i] == this.a)
							{
								return;
							}
							if (serviceOrThrow.aqu().v().Offense.ai[i] == null)
							{
								num2 = i;
								break;
							}
						}
						if (num2 != -1)
						{
							serviceOrThrow.aqu().v().Offense.ai[num2] = this.a;
						}
					}
				}
			}
		}
	}

	// Token: 0x040024CB RID: 9419
	private new string a;

	// Token: 0x040024CC RID: 9420
	private bool b;

	// Token: 0x040024CD RID: 9421
	private bool c;
}
