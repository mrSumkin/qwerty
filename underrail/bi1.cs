using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020010BD RID: 4285
[eiz("GTOAO")]
[Serializable]
public sealed class bi1 : cze, ISerializable
{
	// Token: 0x06005A0B RID: 23051 RVA: 0x0026DEDC File Offset: 0x0026C0DC
	private bi1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("GTOAO:E");
		this.b = A_0.GetString("GTOAO:OGC");
		di7.ReadList<string>("GTOAO:GS", ref this.c, A_0);
	}

	// Token: 0x06005A0C RID: 23052 RVA: 0x0026DF30 File Offset: 0x0026C130
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("GTOAO:E", this.a);
		info.AddValue("GTOAO:OGC", this.b);
		di7.WriteList<string>("GTOAO:GS", this.c, info);
	}

	// Token: 0x06005A0D RID: 23053 RVA: 0x0026DF78 File Offset: 0x0026C178
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06005A0E RID: 23054 RVA: 0x0026DF80 File Offset: 0x0026C180
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005A0F RID: 23055 RVA: 0x0026DF8C File Offset: 0x0026C18C
	public string b()
	{
		return this.b;
	}

	// Token: 0x06005A10 RID: 23056 RVA: 0x0026DF94 File Offset: 0x0026C194
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005A11 RID: 23057 RVA: 0x0026DFA0 File Offset: 0x0026C1A0
	public List<string> c()
	{
		return this.c;
	}

	// Token: 0x06005A12 RID: 23058 RVA: 0x0026DFA8 File Offset: 0x0026C1A8
	public void a(List<string> A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005A13 RID: 23059 RVA: 0x0026DFB4 File Offset: 0x0026C1B4
	public bi1()
	{
	}

	// Token: 0x06005A14 RID: 23060 RVA: 0x0026DFCC File Offset: 0x0026C1CC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null)
		{
			c1a c1a = serviceOrThrow.aqw();
			if (c1a != null)
			{
				foreach (aud a_ in Enumerable.ToList<aud>(c1a.Areas))
				{
					foreach (string text in this.c)
					{
						if (!string.IsNullOrWhiteSpace(text))
						{
							c5x c5x = new ar7(new Guid(text), a_).ao() as c5x;
							if (c5x != null)
							{
								dxv aspect = c5x.GetAspect<dxv>();
								if (aspect != null)
								{
									if (this.b != null && !string.IsNullOrWhiteSpace(this.b))
									{
										aspect.a(this.b);
									}
									aspect.a(this.a);
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0400241C RID: 9244
	private new bool a;

	// Token: 0x0400241D RID: 9245
	private string b;

	// Token: 0x0400241E RID: 9246
	private List<string> c = new List<string>();
}
