using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000F58 RID: 3928
[eiz("XPHWGCBUC")]
[Serializable]
public sealed class etp : dnh, ISerializable
{
	// Token: 0x06004F95 RID: 20373 RVA: 0x0023D2F4 File Offset: 0x0023B4F4
	private etp(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("XPHWGCBUC:I");
	}

	// Token: 0x06004F96 RID: 20374 RVA: 0x0023D310 File Offset: 0x0023B510
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XPHWGCBUC:I", this.a);
	}

	// Token: 0x06004F97 RID: 20375 RVA: 0x0023D32C File Offset: 0x0023B52C
	public bool b()
	{
		return this.a;
	}

	// Token: 0x06004F98 RID: 20376 RVA: 0x0023D334 File Offset: 0x0023B534
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004F99 RID: 20377 RVA: 0x0023D340 File Offset: 0x0023B540
	public etp()
	{
	}

	// Token: 0x06004F9A RID: 20378 RVA: 0x0023D348 File Offset: 0x0023B548
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		bool flag = false;
		cnk service = bpo.GetService<cnk>();
		if (service.aqu() != null)
		{
			aud a_ = service.aqu().v().b().Area;
			c5x c5x = new ar7(c29.a, a_).ao() as c5x;
			if (c5x != null && c5x.h.b != null)
			{
				foreach (coh coh in Enumerable.ToList<coh>(c5x.h.b.aa().Bag.z2()))
				{
					if (coh.Definition != null && coh.Definition is dgn && d7o.a(coh.Definition.a5()))
					{
						flag = true;
						break;
					}
				}
			}
		}
		return flag ^ this.a;
	}

	// Token: 0x06004F9B RID: 20379 RVA: 0x0023D44C File Offset: 0x0023B64C
	public string a()
	{
		return "Стрелок может улучшать свои навыки.";
	}

	// Token: 0x04002093 RID: 8339
	private bool a;
}
