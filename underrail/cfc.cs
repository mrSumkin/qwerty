using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020007B7 RID: 1975
[eiz("DCMTG")]
[Serializable]
public sealed class cfc : esc, ISerializable
{
	// Token: 0x06003177 RID: 12663 RVA: 0x0012F408 File Offset: 0x0012D608
	private cfc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid)A_0.GetValue("DCMTG:I", typeof(Guid));
	}

	// Token: 0x06003178 RID: 12664 RVA: 0x0012F434 File Offset: 0x0012D634
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DCMTG:I", this.a);
	}

	// Token: 0x06003179 RID: 12665 RVA: 0x0012F454 File Offset: 0x0012D654
	public Guid a()
	{
		return this.a;
	}

	// Token: 0x0600317A RID: 12666 RVA: 0x0012F45C File Offset: 0x0012D65C
	public void a(Guid A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600317B RID: 12667 RVA: 0x0012F468 File Offset: 0x0012D668
	public cfc()
	{
	}

	// Token: 0x0600317C RID: 12668 RVA: 0x0012F474 File Offset: 0x0012D674
	public override int d5(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			string text = "ОШИБКА: Не найден мутаген.";
			if (serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null && serviceOrThrow.aqu().v().b().Area != null)
			{
				c7j c7j = new EntityAspectReference<c7j, bim>(serviceOrThrow.aqu().v().b().Area, this.a).ao();
				if (c7j != null)
				{
					if (c7j.ItemContainer.z2().Count == 0)
					{
						text = "ОШИБКА: Ничего не найдено.";
					}
					else if (c7j.ItemContainer.z2().Count > 1)
					{
						text = "ОШИБКА: Найдено несколько предметов.";
					}
					else
					{
						int? num = null;
						coh coh = c7j.ItemContainer.z2()[0];
						string classPropertyValue = coh.Definition.a7().GetClassPropertyValue<string>("MutagenName");
						num = coh.Definition.a7().GetPrimitivePropertyValue<int>("MutagenReagentIndex", null);
						if (num != null && !string.IsNullOrEmpty(classPropertyValue))
						{
							if (coh.Definition.a5() == "mutagenReagent.exitus.1")
							{
								text = "Имя реагента: Незарегистрированный реагент";
								text = text + "\r\nПоследовательность: " + serviceOrThrow.aqu().u().e.a(serviceOrThrow.aqu().u());
							}
							else
							{
								int? num2 = num;
								int num3 = euk.a;
								if (num2.GetValueOrDefault() >= num3 & num2 != null)
								{
									text = "Имя реагента: Незарегистрированный реагент";
									text += "\r\nПоследовательность: Нельзя прочитать последовательность";
								}
								else
								{
									text = "Реагент: " + classPropertyValue;
									text = text + "\r\nПоследовательность: " + serviceOrThrow.aqu().u().d[num.Value].a(serviceOrThrow.aqu().u());
								}
							}
						}
						else
						{
							text = "ОШИБКА: Не найден контейнер с мутагеном";
						}
					}
				}
			}
			serviceOrThrow.aqu().r()["loc_dc_mutagenScanMessage"] = text;
		}
		return 0;
	}

	// Token: 0x04001AB1 RID: 6833
	private Guid a;
}
