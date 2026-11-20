using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000F63 RID: 3939
[eiz("XPBLDCHRHCC")]
[Serializable]
public sealed class ddn : dnh, ISerializable
{
	// Token: 0x06004FD5 RID: 20437 RVA: 0x0023DB94 File Offset: 0x0023BD94
	private ddn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid?)A_0.GetValue("XPBLDCHRHCC:HI", typeof(Guid?));
		this.b = A_0.GetString("XPBLDCHRHCC:C");
	}

	// Token: 0x06004FD6 RID: 20438 RVA: 0x0023DBD0 File Offset: 0x0023BDD0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XPBLDCHRHCC:HI", this.a);
		info.AddValue("XPBLDCHRHCC:C", this.b);
	}

	// Token: 0x06004FD7 RID: 20439 RVA: 0x0023DC04 File Offset: 0x0023BE04
	public Guid? b()
	{
		return this.a;
	}

	// Token: 0x06004FD8 RID: 20440 RVA: 0x0023DC0C File Offset: 0x0023BE0C
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004FD9 RID: 20441 RVA: 0x0023DC18 File Offset: 0x0023BE18
	public string a()
	{
		return this.b;
	}

	// Token: 0x06004FDA RID: 20442 RVA: 0x0023DC20 File Offset: 0x0023BE20
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06004FDB RID: 20443 RVA: 0x0023DC2C File Offset: 0x0023BE2C
	public ddn()
	{
	}

	// Token: 0x06004FDC RID: 20444 RVA: 0x0023DC38 File Offset: 0x0023BE38
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			c5x c5x;
			if (this.a != null)
			{
				c5x = (new ar7(this.a.Value, serviceOrThrow.aqw().n("xpbl_dun_cvw_hr")).ao() as c5x);
			}
			else
			{
				c5x = (A_0.GetPropertyValue(c49.b) as c5x);
			}
			if (c5x != null)
			{
				a3f aspect = c5x.GetAspect<a3f>();
				if (aspect != null)
				{
					List<string> classPropertyValue = aspect.a().GetClassPropertyValue<List<string>>("Characteristics");
					if (Enumerable.Any<string>(classPropertyValue))
					{
						return classPropertyValue.Contains(this.b);
					}
				}
			}
		}
		return false;
	}

	// Token: 0x04002098 RID: 8344
	private Guid? a;

	// Token: 0x04002099 RID: 8345
	private string b;
}
