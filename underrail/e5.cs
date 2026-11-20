using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000F4F RID: 3919
[eiz("PHNIFFR")]
[Serializable]
public sealed class e5 : dnh, ISerializable
{
	// Token: 0x06004F4A RID: 20298 RVA: 0x0023C50C File Offset: 0x0023A70C
	private e5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("PHNIFFR:FC");
		this.b = A_0.GetBoolean("PHNIFFR:I");
	}

	// Token: 0x06004F4B RID: 20299 RVA: 0x0023C538 File Offset: 0x0023A738
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PHNIFFR:FC", this.a);
		info.AddValue("PHNIFFR:I", this.b);
	}

	// Token: 0x06004F4C RID: 20300 RVA: 0x0023C564 File Offset: 0x0023A764
	public string b()
	{
		return this.a;
	}

	// Token: 0x06004F4D RID: 20301 RVA: 0x0023C56C File Offset: 0x0023A76C
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004F4E RID: 20302 RVA: 0x0023C578 File Offset: 0x0023A778
	public bool c()
	{
		return this.b;
	}

	// Token: 0x06004F4F RID: 20303 RVA: 0x0023C580 File Offset: 0x0023A780
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06004F50 RID: 20304 RVA: 0x0023C58C File Offset: 0x0023A78C
	public e5()
	{
	}

	// Token: 0x06004F51 RID: 20305 RVA: 0x0023C598 File Offset: 0x0023A798
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqw() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.h.b != null)
			{
				int num;
				int num2;
				List<string> list = sg.a(this.a, out num, out num2);
				if (list != null && Enumerable.Any<string>(list))
				{
					foreach (string text in list)
					{
						if (text.Contains("Frame") || text == "supersteel")
						{
							List<coh> list2 = Enumerable.ToList<coh>(c5x.h.b.aa().Bag.b(text));
							if (!Enumerable.Any<coh>(list2))
							{
								return this.b;
							}
							bool flag = false;
							using (List<coh>.Enumerator enumerator2 = list2.GetEnumerator())
							{
								while (enumerator2.MoveNext())
								{
									if ((enumerator2.Current as fv).QualityLevel >= num)
									{
										flag = true;
									}
								}
							}
							if (!flag)
							{
								return this.b;
							}
						}
						else if (c5x.h.b.aa().a(text, true) == null)
						{
							return this.b;
						}
					}
				}
				coh coh = serviceOrThrow.aqu().v().a("currency.sc", true);
				if (coh == null || coh.Stacks < num2)
				{
					return this.b;
				}
				return !this.b;
			}
		}
		return this.b;
	}

	// Token: 0x06004F52 RID: 20306 RVA: 0x0023C79C File Offset: 0x0023A99C
	public string a()
	{
		return "PlayerHasNecessaryItemsForFirearmRefurbishment";
	}

	// Token: 0x04002084 RID: 8324
	private string a;

	// Token: 0x04002085 RID: 8325
	private bool b;
}
