using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B7B RID: 2939
[eiz("CCFOENDR")]
[Serializable]
public sealed class gc : cze, ISerializable
{
	// Token: 0x06004327 RID: 17191 RVA: 0x001A3E48 File Offset: 0x001A2048
	private gc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004328 RID: 17192 RVA: 0x001A3E54 File Offset: 0x001A2054
	public gc()
	{
	}

	// Token: 0x06004329 RID: 17193 RVA: 0x001A3E60 File Offset: 0x001A2060
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null)
		{
			bd6 bd = new bd6();
			bd.a(true);
			bd.a("cc_forger_noName");
			bd.ym(null, null, null);
			bd6 bd2 = new bd6();
			bd2.a(true);
			bd2.a("cc_forger_name");
			bd2.ym(null, null, null);
			bd6 bd3 = new bd6();
			bd3.a(true);
			bd3.a("cc_forgerFindHVCables");
			bd3.ym(null, null, null);
			bd6 bd4 = new bd6();
			bd4.a(true);
			bd4.a("cc_forgerTicketTesting");
			bd4.ym(null, null, null);
			bd6 bd5 = new bd6();
			bd5.a(true);
			bd5.a("cc_forgerHVPenetratorAssembly");
			bd5.ym(null, null, null);
			bd6 bd6 = new bd6();
			bd6.a(true);
			bd6.a("cc_forgerOverchargeFacility");
			bd6.ym(null, null, null);
			if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_forger_dead", new bool?(false)).Value)
			{
				serviceOrThrow.aqu().r()["npc_forger_captured"] = true;
				e2l e2l = new e2l();
				e2l.a(1);
				e2l.a("cc_utility2");
				e2l.a(new auc());
				e2l.ym(null, null, null);
				bv9 bv = serviceOrThrow.aqu().ac() as bv9;
				cky cky = bv.abu(asp.a, asp.dz);
				cky cky2 = bv.abu(asp.a, asp.d1);
				cky cky3 = bv.abu(asp.a, asp.d0);
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("faction_Coretech_joined", new bool?(false)).Value && cky.a != h.a)
				{
					serviceOrThrow.aqu().b(new cow("npc_forger_CoretechEnding"));
					return;
				}
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("faction_JKK_joined", new bool?(false)).Value && cky2.a != h.a)
				{
					serviceOrThrow.aqu().b(new cow("npc_forger_JkkEnding"));
					return;
				}
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("faction_Preatorian_joined", new bool?(false)).Value && cky3.a != h.a)
				{
					serviceOrThrow.aqu().b(new cow("npc_forger_PraetorianEnding"));
					return;
				}
				if (cky.a != h.a && cky2.a != h.a && cky3.a != h.a)
				{
					switch (cuo.a.Next(0, 3))
					{
					case 0:
						serviceOrThrow.aqu().r()["npc_forger_CoretechEnding"] = true;
						return;
					case 1:
						serviceOrThrow.aqu().r()["npc_forger_PraetorianEnding"] = true;
						return;
					case 2:
						serviceOrThrow.aqu().r()["npc_forger_JkkEnding"] = true;
						return;
					default:
						serviceOrThrow.aqu().r()["npc_forger_PraetorianEnding"] = true;
						break;
					}
				}
			}
		}
	}
}
