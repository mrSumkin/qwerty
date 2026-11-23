using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020004CC RID: 1228
[eiz("CCAVC")]
[Serializable]
public sealed class bqf : dnh, ISerializable
{
	// Token: 0x06001F76 RID: 8054 RVA: 0x000AD5D0 File Offset: 0x000AB7D0
	private bqf(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("CHIEC:V");
		this.b = A_0.GetBoolean("CHIEC:I");
		this.c = (A_0.GetValue("CHIEC:N", typeof(Guid?)) as Guid?);
	}

	// Token: 0x06001F77 RID: 8055 RVA: 0x000AD62C File Offset: 0x000AB82C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CHIEC:V", this.a);
		info.AddValue("CHIEC:I", this.b);
		info.AddValue("CHIEC:N", this.c);
	}

	// Token: 0x06001F78 RID: 8056 RVA: 0x000AD67C File Offset: 0x000AB87C
	public string b()
	{
		return this.a;
	}

	// Token: 0x06001F79 RID: 8057 RVA: 0x000AD684 File Offset: 0x000AB884
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001F7A RID: 8058 RVA: 0x000AD690 File Offset: 0x000AB890
	public bool c()
	{
		return this.b;
	}

	// Token: 0x06001F7B RID: 8059 RVA: 0x000AD698 File Offset: 0x000AB898
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06001F7C RID: 8060 RVA: 0x000AD6A4 File Offset: 0x000AB8A4
	public Guid? a()
	{
		return this.c;
	}

	// Token: 0x06001F7D RID: 8061 RVA: 0x000AD6AC File Offset: 0x000AB8AC
	public void a(Guid? A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06001F7E RID: 8062 RVA: 0x000AD6B8 File Offset: 0x000AB8B8
	public bqf()
	{
	}

	// Token: 0x06001F7F RID: 8063 RVA: 0x000AD6C0 File Offset: 0x000AB8C0
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		bool flag = false;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.a != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null && serviceOrThrow.aqu().v().b().Area != null)
		{
			efk efk = null;
			if (this.c != null)
			{
				EntityAspectReference<amc, amc> entityAspectReference = new EntityAspectReference<amc, amc>(serviceOrThrow.aqu().v().b().Area, this.c.Value);
				if (entityAspectReference.ao() != null)
				{
					efk = entityAspectReference.ao().aa();
				}
			}
			else
			{
				efk = serviceOrThrow.aqu().v();
			}
			if (efk != null)
			{
				flag = ((efk.Gear.l().Item == null && string.IsNullOrEmpty(this.a)) || (efk.Gear.l().Item != null && string.Equals(efk.Gear.l().Item.fu().e(), this.a, StringComparison.OrdinalIgnoreCase)));
			}
		}
		return flag ^ this.b;
	}

	// Token: 0x040013D0 RID: 5072
	private string a;

	// Token: 0x040013D1 RID: 5073
	private bool b;

	// Token: 0x040013D2 RID: 5074
	private Guid? c;
}
