using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000AEF RID: 2799
[eiz("XPBLPIRSAAJ")]
[Serializable]
public sealed class c8z : cze, ISerializable
{
	// Token: 0x06004109 RID: 16649 RVA: 0x0018C928 File Offset: 0x0018AB28
	private c8z(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("XPBLPIRSAAJ:O");
	}

	// Token: 0x0600410A RID: 16650 RVA: 0x0018C944 File Offset: 0x0018AB44
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XPBLPIRSAAJ:O", this.a);
	}

	// Token: 0x0600410B RID: 16651 RVA: 0x0018C960 File Offset: 0x0018AB60
	public string a()
	{
		return this.a;
	}

	// Token: 0x0600410C RID: 16652 RVA: 0x0018C968 File Offset: 0x0018AB68
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600410D RID: 16653 RVA: 0x0018C974 File Offset: 0x0018AB74
	public c8z(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600410E RID: 16654 RVA: 0x0018C984 File Offset: 0x0018AB84
	public c8z()
	{
	}

	// Token: 0x0600410F RID: 16655 RVA: 0x0018C990 File Offset: 0x0018AB90
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			foreach (string a_ in new List<string>
			{
				"xpbl_e3",
				"xpbl_f3",
				"xpbl_g3"
			})
			{
				serviceOrThrow.aqu().a(new bw0(a_, new a39(), 1));
			}
			if (this.a == "spawnstay" || this.a == "spawndie")
			{
				if (this.a == "spawnstay")
				{
					serviceOrThrow.aqu().r()["loc_xpbl_portCeto_underAttack"] = true;
				}
				else
				{
					serviceOrThrow.aqu().r()["faction_xpbl_pir_gotAegisJets"] = true;
				}
				serviceOrThrow.aqu().b(new eww());
			}
			int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("global_xpbl_aegisSecTroopersAvailable", new int?(0)).Value;
			int value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xpbl_expedition_jetSkiStrength", new int?(0)).Value;
			serviceOrThrow.aqu().r()["global_xpbl_aegisSecTroopersAvailable"] = value - 5;
			serviceOrThrow.aqu().r()["faction_xpbl_expedition_jetSkiStrength"] = value2 - 1;
			serviceOrThrow.aqu().r()["loc_xpbl_pir_aegisAttack_whatHappens"] = this.a;
			serviceOrThrow.aqu().r()["loc_xpbl_portCeto_attackedByAegis"] = true;
			eaq eaq = new eaq();
			eaq.b(asp.f5);
			eaq.a(asp.fr);
			eaq.a(h.a);
			eaq.a(true);
			eaq.ym(null, null, null);
		}
	}

	// Token: 0x04001C10 RID: 7184
	private new string a;
}
