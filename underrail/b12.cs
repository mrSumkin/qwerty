using System;
using System.Runtime.Serialization;

// Token: 0x02000F4D RID: 3917
[eiz("TCHRHCUC")]
[Serializable]
public sealed class b12 : dnh, ISerializable
{
	// Token: 0x06004F3A RID: 20282 RVA: 0x0023C224 File Offset: 0x0023A424
	private b12(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("TCHRHCUC:I");
	}

	// Token: 0x06004F3B RID: 20283 RVA: 0x0023C240 File Offset: 0x0023A440
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TCHRHCUC:I", this.a);
	}

	// Token: 0x06004F3C RID: 20284 RVA: 0x0023C25C File Offset: 0x0023A45C
	public bool b()
	{
		return this.a;
	}

	// Token: 0x06004F3D RID: 20285 RVA: 0x0023C264 File Offset: 0x0023A464
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004F3E RID: 20286 RVA: 0x0023C270 File Offset: 0x0023A470
	public b12()
	{
	}

	// Token: 0x06004F3F RID: 20287 RVA: 0x0023C27C File Offset: 0x0023A47C
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			string[] array = new string[]
			{
				"ce39cc58-3a82-4411-b7c3-bdac954044ba",
				"936f317c-bfb4-476f-81a5-9b007ceca798",
				"ddfdf6c9-8d99-4261-84c3-f92f53908112",
				"5a063577-efd4-4258-a50e-f224b96391fe",
				"be34ee44-976f-44cb-9134-5cdb9fb44c0a"
			};
			for (int i = 0; i < array.Length; i++)
			{
				c5x c5x = new ar7(new Guid(array[i]), serviceOrThrow.aqw().n("tch-util3")).ao() as c5x;
				if (c5x != null)
				{
					d2b aspect = c5x.GetAspect<d2b>();
					if (aspect != null && aspect.n())
					{
						return this.a;
					}
				}
			}
			return !this.a;
		}
		return this.a;
	}

	// Token: 0x06004F40 RID: 20288 RVA: 0x0023C350 File Offset: 0x0023A550
	public string a()
	{
		return "Tch_Util3_RejectHoldingCellsUnlockedCondition";
	}

	// Token: 0x04002081 RID: 8321
	private bool a;
}
