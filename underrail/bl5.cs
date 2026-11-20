using System;
using System.Runtime.Serialization;

// Token: 0x02000F51 RID: 3921
[eiz("DDRSSC")]
[Serializable]
public sealed class bl5 : dnh, ISerializable
{
	// Token: 0x06004F62 RID: 20322 RVA: 0x0023CB04 File Offset: 0x0023AD04
	private bl5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("DDRSSC:V");
		this.b = (ei6)A_0.GetValue("DDRSSC:CT", typeof(ei6));
	}

	// Token: 0x06004F63 RID: 20323 RVA: 0x0023CB54 File Offset: 0x0023AD54
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DDRSSC:V", this.a);
		info.AddValue("DDRSSC:CT", this.b);
	}

	// Token: 0x06004F64 RID: 20324 RVA: 0x0023CB88 File Offset: 0x0023AD88
	public int b()
	{
		return this.a;
	}

	// Token: 0x06004F65 RID: 20325 RVA: 0x0023CB90 File Offset: 0x0023AD90
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004F66 RID: 20326 RVA: 0x0023CB9C File Offset: 0x0023AD9C
	public ei6 a()
	{
		return this.b;
	}

	// Token: 0x06004F67 RID: 20327 RVA: 0x0023CBA4 File Offset: 0x0023ADA4
	public void a(ei6 A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06004F68 RID: 20328 RVA: 0x0023CBB0 File Offset: 0x0023ADB0
	public bl5()
	{
	}

	// Token: 0x06004F69 RID: 20329 RVA: 0x0023CBC0 File Offset: 0x0023ADC0
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			c5x c5x = new ar7(new Guid("8e9f02c5-769c-4411-a090-b21df89f6ef5"), serviceOrThrow.aqu().v().b().Area).ao() as c5x;
			if (c5x != null)
			{
				dvp aspect = c5x.GetAspect<dvp>();
				if (aspect != null)
				{
					switch (this.b)
					{
					case ei6.a:
						return aspect.ap7().z2().Count == this.a;
					case ei6.b:
						return aspect.ap7().z2().Count > this.a;
					case ei6.c:
						return aspect.ap7().z2().Count < this.a;
					case ei6.d:
						return aspect.ap7().z2().Count >= this.a;
					case ei6.e:
						return aspect.ap7().z2().Count <= this.a;
					case ei6.f:
						return aspect.ap7().z2().Count != this.a;
					default:
						return false;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06004F6A RID: 20330 RVA: 0x0023CD00 File Offset: 0x0023AF00
	public string c()
	{
		return "Diedrick Store State";
	}

	// Token: 0x0400208B RID: 8331
	private int a;

	// Token: 0x0400208C RID: 8332
	private ei6 b = ei6.a;
}
