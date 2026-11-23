using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020007B4 RID: 1972
[eiz("DCCMR")]
[Serializable]
public sealed class cye : esc, ISerializable
{
	// Token: 0x06003168 RID: 12648 RVA: 0x0012F070 File Offset: 0x0012D270
	private cye(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid)A_0.GetValue("DCCMR:I", typeof(Guid));
	}

	// Token: 0x06003169 RID: 12649 RVA: 0x0012F09C File Offset: 0x0012D29C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DCCMR:I", this.a);
	}

	// Token: 0x0600316A RID: 12650 RVA: 0x0012F0BC File Offset: 0x0012D2BC
	public Guid a()
	{
		return this.a;
	}

	// Token: 0x0600316B RID: 12651 RVA: 0x0012F0C4 File Offset: 0x0012D2C4
	public void a(Guid A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600316C RID: 12652 RVA: 0x0012F0D0 File Offset: 0x0012D2D0
	public cye()
	{
	}

	// Token: 0x0600316D RID: 12653 RVA: 0x0012F0D8 File Offset: 0x0012D2D8
	public override int d5(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			string value = "ОШИБКА: Не найдены реагенты.";
			bool flag = false;
			HashSet<int> hashSet = new HashSet<int>();
			if (serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null && serviceOrThrow.aqu().v().b().Area != null)
			{
				c7j c7j = new EntityAspectReference<c7j, bim>(serviceOrThrow.aqu().v().b().Area, this.a).ao();
				if (c7j != null && c7j.ItemContainer.z2().Count > 0)
				{
					foreach (coh coh in c7j.ItemContainer.z2())
					{
						int? primitivePropertyValue = coh.Definition.a7().GetPrimitivePropertyValue<int>("MutagenReagentIndex", null);
						if (primitivePropertyValue != null)
						{
							hashSet.Add(primitivePropertyValue.Value);
						}
						else
						{
							flag = true;
							value = "ОШИБКА: Обнаружен посторонний предмет.";
						}
					}
				}
			}
			if (serviceOrThrow.aqu().r().GetClassPropertyValue<string>("dc_mutagenCompoundText") == null)
			{
				serviceOrThrow.aqu().r()["dc_mutagenCompoundText"] = "";
			}
			serviceOrThrow.aqu().r()["loc_dc_mutagenReagentsPresent"] = hashSet;
			serviceOrThrow.aqu().r()["loc_dc_mutagenCombinatorMessage"] = value;
			serviceOrThrow.aqu().r()["loc_dc_mutagenCombinatorError"] = flag;
		}
		return 0;
	}

	// Token: 0x04001AAF RID: 6831
	private Guid a;
}
