using System;
using System.Linq;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020004C8 RID: 1224
[eiz("PCIMC")]
[Serializable]
public sealed class bju : dnh, ISerializable
{
	// Token: 0x06001F55 RID: 8021 RVA: 0x000ACFA8 File Offset: 0x000AB1A8
	private bju(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("PCIMC:I");
		this.b = (A_0.GetValue("PCIMC:N", typeof(Guid?)) as Guid?);
		this.c = A_0.GetString("PCIMC:R");
	}

	// Token: 0x06001F56 RID: 8022 RVA: 0x000AD004 File Offset: 0x000AB204
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PCIMC:I", this.a);
		info.AddValue("PCIMC:N", this.b);
		info.AddValue("PCIMC:R", this.c);
	}

	// Token: 0x06001F57 RID: 8023 RVA: 0x000AD054 File Offset: 0x000AB254
	public bool c()
	{
		return this.a;
	}

	// Token: 0x06001F58 RID: 8024 RVA: 0x000AD05C File Offset: 0x000AB25C
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001F59 RID: 8025 RVA: 0x000AD068 File Offset: 0x000AB268
	public Guid? a()
	{
		return this.b;
	}

	// Token: 0x06001F5A RID: 8026 RVA: 0x000AD070 File Offset: 0x000AB270
	public void a(Guid? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06001F5B RID: 8027 RVA: 0x000AD07C File Offset: 0x000AB27C
	public string b()
	{
		return this.c;
	}

	// Token: 0x06001F5C RID: 8028 RVA: 0x000AD084 File Offset: 0x000AB284
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06001F5D RID: 8029 RVA: 0x000AD090 File Offset: 0x000AB290
	public bju()
	{
	}

	// Token: 0x06001F5E RID: 8030 RVA: 0x000AD098 File Offset: 0x000AB298
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		bool flag = false;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			efk efk = null;
			if (this.b != null)
			{
				EntityAspectReference<amc, amc> entityAspectReference = new EntityAspectReference<amc, amc>(serviceOrThrow.aqu().v().b().Area, this.b.Value);
				if (entityAspectReference.ao() != null)
				{
					efk = entityAspectReference.ao().aa();
				}
			}
			else if (!string.IsNullOrWhiteSpace(this.c))
			{
				d60 addon = serviceOrThrow.aqw().GetAddon<d60>();
				if (addon != null)
				{
					c5x c5x = Enumerable.FirstOrDefault<b0b>(addon.ab4(new string[]
					{
						this.c
					})) as c5x;
					if (c5x != null && c5x.h.b != null)
					{
						efk = c5x.h.b.aa();
					}
				}
			}
			else
			{
				efk = serviceOrThrow.aqu().v();
			}
			if (efk != null)
			{
				flag = !efk.SpecialStates.b;
			}
		}
		return flag ^ this.a;
	}

	// Token: 0x040013C5 RID: 5061
	private bool a;

	// Token: 0x040013C6 RID: 5062
	private Guid? b;

	// Token: 0x040013C7 RID: 5063
	private string c;
}
