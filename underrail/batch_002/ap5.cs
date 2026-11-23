using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000F64 RID: 3940
[eiz("XPBLOJYC3PKSTC")]
[Serializable]
public sealed class ap5 : dnh, ISerializable
{
	// Token: 0x06004FDD RID: 20445 RVA: 0x0023DCE4 File Offset: 0x0023BEE4
	private ap5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("XPBLOJYC3PKSTC:I");
		this.b = A_0.GetString("XPBLOJYC3PKSTC:ST");
	}

	// Token: 0x06004FDE RID: 20446 RVA: 0x0023DD10 File Offset: 0x0023BF10
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XPBLOJYC3PKSTC:I", this.a);
		info.AddValue("XPBLOJYC3PKSTC:ST", this.b);
	}

	// Token: 0x06004FDF RID: 20447 RVA: 0x0023DD3C File Offset: 0x0023BF3C
	public string a()
	{
		return this.b;
	}

	// Token: 0x06004FE0 RID: 20448 RVA: 0x0023DD44 File Offset: 0x0023BF44
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06004FE1 RID: 20449 RVA: 0x0023DD50 File Offset: 0x0023BF50
	public bool b()
	{
		return this.a;
	}

	// Token: 0x06004FE2 RID: 20450 RVA: 0x0023DD58 File Offset: 0x0023BF58
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004FE3 RID: 20451 RVA: 0x0023DD64 File Offset: 0x0023BF64
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x c5x2 = new ar7(new Guid("ea617c2a-fd77-4031-a407-3d2d35e6ede6"), c5x.Area).ao() as c5x;
				if (c5x2 != null)
				{
					a3f aspect = c5x2.GetAspect<a3f>();
					if (aspect != null)
					{
						SortedSet<string> sortedSet = aspect.a().GetClassPropertyValue<SortedSet<string>>("xpbl_ojyc3_playerKnowledge");
						if (sortedSet == null)
						{
							SortedSet<string> sortedSet2 = new SortedSet<string>();
							sortedSet2.Add("Biocorp");
							sortedSet = sortedSet2;
							aspect.a()["xpbl_ojyc3_playerKnowledge"] = sortedSet;
						}
						if (sortedSet.Contains(this.a()))
						{
							return !this.b();
						}
						return this.b();
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06004FE4 RID: 20452 RVA: 0x0023DE50 File Offset: 0x0023C050
	public ap5()
	{
	}

	// Token: 0x0400209A RID: 8346
	private bool a;

	// Token: 0x0400209B RID: 8347
	private string b;
}
