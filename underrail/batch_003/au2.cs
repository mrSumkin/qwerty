using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x0200067C RID: 1660
[eiz("P2")]
[Serializable]
public sealed class au2 : e3q, ISerializable
{
	// Token: 0x06002A4D RID: 10829 RVA: 0x000EE5B4 File Offset: 0x000EC7B4
	private au2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (bag)A_0.GetValue("P2:O", typeof(bag));
			return;
		}
		if (base.GetType() == typeof(au2))
		{
			this.a = (bag)A_0.GetValue("_Observer", typeof(bag));
			return;
		}
		this.a = (bag)A_0.GetValue("Player+_Observer", typeof(bag));
	}

	// Token: 0x06002A4E RID: 10830 RVA: 0x000EE650 File Offset: 0x000EC850
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("P2:O", this.a);
	}

	// Token: 0x06002A4F RID: 10831 RVA: 0x000EE66C File Offset: 0x000EC86C
	public bag a()
	{
		return this.a;
	}

	// Token: 0x06002A50 RID: 10832 RVA: 0x000EE674 File Offset: 0x000EC874
	public b0b b()
	{
		return this.b;
	}

	// Token: 0x06002A51 RID: 10833 RVA: 0x000EE67C File Offset: 0x000EC87C
	public void a(b0b A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002A52 RID: 10834 RVA: 0x000EE688 File Offset: 0x000EC888
	public au2()
	{
		this.a = new bag("PlayerCharacterObserver", dm9.a);
		this.a.a(true);
	}

	// Token: 0x06002A53 RID: 10835 RVA: 0x000EE6B4 File Offset: 0x000EC8B4
	public TypedObjectReference<bag> c()
	{
		return new au2.a();
	}

	// Token: 0x04001701 RID: 5889
	private new bag a;

	// Token: 0x04001702 RID: 5890
	[NonSerialized]
	private new b0b b;

	// Token: 0x0200067E RID: 1662
	[eiz("POR")]
	[Serializable]
	private new class a : TypedObjectReference<bag>, ISerializable
	{
		// Token: 0x06002A7A RID: 10874 RVA: 0x000EF574 File Offset: 0x000ED774
		protected a(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
		{
		}

		// Token: 0x06002A7B RID: 10875 RVA: 0x000EF580 File Offset: 0x000ED780
		public a()
		{
		}

		// Token: 0x06002A7C RID: 10876 RVA: 0x000EF58C File Offset: 0x000ED78C
		protected override bag h4()
		{
			cnk service = bpo.GetService<cnk>();
			if (service != null && service.aqu() != null && service.aqu().v() != null)
			{
				return service.aqu().v().a();
			}
			return null;
		}
	}
}
