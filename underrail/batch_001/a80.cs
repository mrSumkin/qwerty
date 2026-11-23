using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020010B8 RID: 4280
[eiz("QPSRJ")]
[Serializable]
public sealed class a80 : cze
{
	// Token: 0x060059F7 RID: 23031 RVA: 0x0026DA60 File Offset: 0x0026BC60
	private a80(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid)A_0.GetValue("QPSRJ:I", typeof(Guid));
		this.b = A_0.GetInt32("QPSRJ:D");
	}

	// Token: 0x060059F8 RID: 23032 RVA: 0x0026DA9C File Offset: 0x0026BC9C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("QPSRJ:I", this.a);
		info.AddValue("QPSRJ:D", this.b);
	}

	// Token: 0x060059F9 RID: 23033 RVA: 0x0026DAD0 File Offset: 0x0026BCD0
	public Guid b()
	{
		return this.a;
	}

	// Token: 0x060059FA RID: 23034 RVA: 0x0026DAD8 File Offset: 0x0026BCD8
	public void a(Guid A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060059FB RID: 23035 RVA: 0x0026DAE4 File Offset: 0x0026BCE4
	public int a()
	{
		return this.b;
	}

	// Token: 0x060059FC RID: 23036 RVA: 0x0026DAEC File Offset: 0x0026BCEC
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060059FD RID: 23037 RVA: 0x0026DAF8 File Offset: 0x0026BCF8
	public a80()
	{
	}

	// Token: 0x060059FE RID: 23038 RVA: 0x0026DB04 File Offset: 0x0026BD04
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqw() != null)
		{
			d60 d = serviceOrThrow.aqw().a();
			if (d != null)
			{
				c5x c5x = Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
				{
					"powerSourceReactivator"
				})) as c5x;
				if (c5x != null)
				{
					a3f aspect = c5x.GetAspect<a3f>();
					if (aspect != null)
					{
						aspect.a()[this.a.ToString()] = this.b;
					}
				}
			}
		}
	}

	// Token: 0x0400241A RID: 9242
	private new Guid a;

	// Token: 0x0400241B RID: 9243
	private int b;
}
