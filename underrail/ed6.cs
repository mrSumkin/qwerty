using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x02001855 RID: 6229
[eiz("UTA")]
[Serializable]
public sealed class ed6 : dvv, ISerializable
{
	// Token: 0x060084D7 RID: 34007 RVA: 0x003739B4 File Offset: 0x00371BB4
	private ed6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (edx)A_0.GetValue("UTA:TR", typeof(edx));
			this.b = (ar7)A_0.GetValue("UTA:ER", typeof(ar7));
			this.c = (Guid)A_0.GetValue("UTA:TI", typeof(Guid));
			return;
		}
		if (base.GetType() == typeof(ed6))
		{
			this.a = (edx)A_0.GetValue("_TileRef", typeof(edx));
			this.b = (ar7)A_0.GetValue("_EntityRef", typeof(ar7));
			this.c = (Guid)A_0.GetValue("_TriggerId", typeof(Guid));
			return;
		}
		this.a = (edx)A_0.GetValue("UseTriggerAction+_TileRef", typeof(edx));
		this.b = (ar7)A_0.GetValue("UseTriggerAction+_EntityRef", typeof(ar7));
		this.c = (Guid)A_0.GetValue("UseTriggerAction+_TriggerId", typeof(Guid));
	}

	// Token: 0x060084D8 RID: 34008 RVA: 0x00373B10 File Offset: 0x00371D10
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("UTA:TR", this.a);
		info.AddValue("UTA:ER", this.b);
		info.AddValue("UTA:TI", this.c);
	}

	// Token: 0x060084D9 RID: 34009 RVA: 0x00373B60 File Offset: 0x00371D60
	private ak1 b()
	{
		return this.a.ao();
	}

	// Token: 0x060084DA RID: 34010 RVA: 0x00373B70 File Offset: 0x00371D70
	private b0b a()
	{
		return this.b.ao();
	}

	// Token: 0x060084DB RID: 34011 RVA: 0x00373B80 File Offset: 0x00371D80
	public ed6(ak1 A_0, b0b A_1, ya A_2)
	{
		czh.a(A_0, "tile");
		czh.a(A_2, "trigger");
		czh.a(A_1, "entity");
		this.a = new edx(A_0);
		this.b = new ar7(A_1);
		this.c = A_2.Id;
	}

	// Token: 0x060084DC RID: 34012 RVA: 0x00373BD8 File Offset: 0x00371DD8
	protected override dc4 dt()
	{
		if (this.b().TriggerProxies != null)
		{
			bqt bqt = Enumerable.FirstOrDefault<bqt>(Enumerable.Where<bqt>(this.b().TriggerProxies, new Func<bqt, bool>(this.a)));
			if (bqt != null && bqt.Trigger != null)
			{
				cdo cdo = bqt.Trigger as cdo;
				if (cdo != null && cdo.c() != null && !cdo.c().jh(null))
				{
					return dc4.e;
				}
				b0j b0j = bqt.Trigger as b0j;
				if (b0j != null && b0j.Condition != null && !b0j.Condition.jh(null))
				{
					return dc4.e;
				}
				bqt.Trigger.d(this.a());
				return dc4.c;
			}
		}
		return dc4.e;
	}

	// Token: 0x060084DD RID: 34013 RVA: 0x00373C9C File Offset: 0x00371E9C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		return dc4.e;
	}

	// Token: 0x060084DE RID: 34014 RVA: 0x00373CA0 File Offset: 0x00371EA0
	[CompilerGenerated]
	private bool a(bqt A_0)
	{
		return A_0.Trigger != null && A_0.Trigger.Id == this.c;
	}

	// Token: 0x040032EC RID: 13036
	private new edx a;

	// Token: 0x040032ED RID: 13037
	private ar7 b;

	// Token: 0x040032EE RID: 13038
	private Guid c;
}
