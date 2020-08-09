Create function dbo.uf_GetPatientsAge()
returns table as
	return (
		(
			Select 'Юношеский период' as 'age', count(dbo.Pacient.age) as 'count'
				From dbo.Pacient
					where dbo.Pacient.age < 18
		)
		Union
		(
			Select 'Зрелый возраст' as 'age', count(dbo.Pacient.age) as 'count'
				From dbo.Pacient
					where dbo.Pacient.age >= 18 and dbo.Pacient.age < 65
		)
		Union
		(
			Select 'Пожилой возраст' as 'age', count(dbo.Pacient.age) as 'count'
				From dbo.Pacient
					where dbo.Pacient.age >= 65
		)
	)